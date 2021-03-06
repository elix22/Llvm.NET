﻿using Llvm.NET.Native;
using Llvm.NET.Values;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Llvm.NET
{
    public class ComdatCollection
        : IEnumerable<Comdat>
    {
        internal ComdatCollection( NativeModule module )
        {
            Module = module;
            NativeMethods.ModuleEnumerateComdats( Module.ModuleHandle, AddComdat );
        }

        public Comdat this[ string key ]
        {
            get
            {
                return InternalComdatMap[ key ];
            }
        }

        public int Count => InternalComdatMap.Count;

        public Comdat Add( string key, ComdatKind kind )
        {
            LLVMComdatRef comdatRef = NativeMethods.ModuleInsertOrUpdateComdat( Module.ModuleHandle, key, ( LLVMComdatSelectionKind )kind );
            Comdat retVal;
            if( !InternalComdatMap.TryGetValue( key, out retVal ) )
            {
                retVal = new Comdat( Module, comdatRef );
                InternalComdatMap.Add( retVal.Name, retVal );
            }
            return retVal;
        }

        public void Clear( )
        {
            foreach( var obj in ModuleGlobalObjects() )
                obj.Comdat = null;

            InternalComdatMap.Clear( );
            NativeMethods.ModuleComdatClear( Module.ModuleHandle );
        }

        public bool Contains( string key ) => InternalComdatMap.ContainsKey( key );

        public IEnumerator<Comdat> GetEnumerator( ) => InternalComdatMap.Values.GetEnumerator( );
        IEnumerator IEnumerable.GetEnumerator( ) => InternalComdatMap.Values.GetEnumerator( );

        public bool Remove( string key )
        {
            Comdat value;
            if( !InternalComdatMap.TryGetValue( key, out value ) )
            {
                return false;
            }

            var retVal = InternalComdatMap.Remove( key );
            if( retVal )
            {
                ClearComdatFromGlobals( key );
                NativeMethods.ModuleComdatRemove( Module.ModuleHandle, value.ComdatHandle );
            }
            return retVal;
        }

        public bool TryGetValue( string key, out Comdat value ) => InternalComdatMap.TryGetValue( key, out value );

        private void ClearComdatFromGlobals( string name )
        {
            var matchingGlobals = from gv in ModuleGlobalObjects( )
                                  where gv.Comdat.Name == name
                                  select gv;

            foreach( var gv in matchingGlobals )
            {
                gv.Comdat = null;
            }
        }

        private bool AddComdat( LLVMComdatRef comdatRef )
        {
            var comdat = new Comdat( Module, comdatRef );
            InternalComdatMap.Add( comdat.Name, comdat );
            return true;
        }

        IEnumerable<GlobalObject> ModuleGlobalObjects()
        {
            foreach( var gv in Module.Globals.OfType<GlobalObject>( ) )
                yield return gv;

            foreach( var func in Module.Functions )
                yield return func;
        }

        private NativeModule Module;
        private Dictionary<string, Comdat> InternalComdatMap = new Dictionary<string, Comdat>( );
    }
}
