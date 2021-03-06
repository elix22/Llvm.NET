﻿// This file was generated from LLVMLib.3.6.1 Extended API using ClangSharp P/Invoke generator
// it was further modified in the following ways:
//  - removed most uses of the partial keyword except for LLVMNative static class
//  - added warning disable to avoid benign compiler warnings about fields only set by native code
//  - modified all elements to be internal instead of public
//  - modified PInvoke attributes to use fully qualified name for CallingConvention to avoid conflicts
//  - removed C++ function unwrap()
//  - removed DEFINE_ISA_CONVERSION_FUNCTIONS which was erroneously mis-identified as a function
//    declaration rather than a preprocessor macro instantiation
//  - converted several int return and parameter types to proper LLVMxxxRef types not handled correctly
//    by the ClangSharp code generator
//  - numerous additional extension methods added manually. (e.g. as new APIs are added they are done so
//    manually rather than re-running a tool and then fixing everything up again )
//  - manually updated to 3.7.0 APIs
//  - added BestFitMapping = false, ThrowOnUnmappableChar = true to resolve FxCop issue CA2101
using System;
using System.Runtime.InteropServices;

namespace Llvm.NET.Native
{
    internal partial struct LLVMMetadataRef
    {
        internal LLVMMetadataRef(IntPtr pointer)
        {
            Pointer = pointer;
        }

        internal readonly IntPtr Pointer;
    }

    internal partial struct LLVMDIBuilderRef
    {
        internal LLVMDIBuilderRef(IntPtr pointer)
        {
            Pointer = pointer;
        }

        internal readonly IntPtr Pointer;
    }

    internal partial struct LLVMMDOperandRef
    {
        internal LLVMMDOperandRef(IntPtr pointer)
        {
            Pointer = pointer;
        }

        internal readonly IntPtr Pointer;
    }

    internal partial struct LLVMNamedMDNodeRef
    {
        internal LLVMNamedMDNodeRef(IntPtr pointer)
        {
            Pointer = pointer;
        }

        internal readonly IntPtr Pointer;
    }

    internal partial struct LLVMComdatRef
    {
        internal LLVMComdatRef( IntPtr pointer )
        {
            Pointer = pointer;
        }

        internal readonly IntPtr Pointer;
    }

    internal partial struct LLVMVersionInfo
    {
        internal readonly int Major;
        internal readonly int Minor;
        internal readonly int Patch;
        readonly IntPtr VersionString;
    }

    internal enum LLVMModFlagBehavior
    {
        @Error = 1,
        @Warning = 2,
        @Require = 3,
        @Override = 4,
        @Append = 5,
        @AppendUnique = 6,
        @ModFlagBehaviorFirstVal = Error,
        @ModFlagBehaviorLastVal = AppendUnique
    }

    internal enum LLVMValueKind
    {
        LLVMArgumentValueKind,
        LLVMBasicBlockValueKind,
        LLVMMemoryUseValueKind,
        LLVMMemoryDefValueKind,
        LLVMMemoryPhiValueKind,

        LLVMFunctionValueKind,
        LLVMGlobalAliasValueKind,
        LLVMGlobalIFuncValueKind,
        LLVMGlobalVariableValueKind,
        LLVMBlockAddressValueKind,
        LLVMConstantExprValueKind,
        LLVMConstantArrayValueKind,
        LLVMConstantStructValueKind,
        LLVMConstantVectorValueKind,

        LLVMUndefValueValueKind,
        LLVMConstantAggregateZeroValueKind,
        LLVMConstantDataArrayValueKind,
        LLVMConstantDataVectorValueKind,
        LLVMConstantIntValueKind,
        LLVMConstantFPValueKind,
        LLVMConstantPointerNullValueKind,
        LLVMConstantTokenNoneValueKind,

        LLVMMetadataAsValueValueKind,
        LLVMInlineAsmValueKind,

        LLVMInstructionValueKind,
    }

    enum LLVMDwarfTag : ushort
    {
        LLVMDwarfTagArrayType = 0x01,
        LLVMDwarfTagClassType = 0x02,
        LLVMDwarfTagEntryPoint = 0x03,
        LLVMDwarfTagEnumerationType = 0x04,
        LLVMDwarfTagFormalParameter = 0x05,
        LLVMDwarfTagImportedDeclaration = 0x08,
        LLVMDwarfTagLabel = 0x0a,
        LLVMDwarfTagLexicalBlock = 0x0b,
        LLVMDwarfTagMember = 0x0d,
        LLVMDwarfTagPointerType = 0x0f,
        LLVMDwarfTagReferenceType = 0x10,
        LLVMDwarfTagCompileUnit = 0x11,
        LLVMDwarfTagStringType = 0x12,
        LLVMDwarfTagStructureType = 0x13,
        LLVMDwarfTagSubroutineType = 0x15,
        LLVMDwarfTagTypeDef = 0x16,
        LLVMDwarfTagUnionType = 0x17,
        LLVMDwarfTagUnspecifiedParameters = 0x18,
        LLVMDwarfTagVariant = 0x19,
        LLVMDwarfTagCommonBlock = 0x1a,
        LLVMDwarfTagCommonInclusion = 0x1b,
        LLVMDwarfTagInheritance = 0x1c,
        LLVMDwarfTagInlinedSubroutine = 0x1d,
        LLVMDwarfTagModule = 0x1e,
        LLVMDwarfTagPtrToMemberType = 0x1f,
        LLVMDwarfTagSetType = 0x20,
        LLVMDwarfTagSubrangeType = 0x21,
        LLVMDwarfTagWithStatement = 0x22,
        LLVMDwarfTagAccessDeclaration = 0x23,
        LLVMDwarfTagBaseType = 0x24,
        LLVMDwarfTagCatchBlock = 0x25,
        LLVMDwarfTagConstType = 0x26,
        LLVMDwarfTagConstant = 0x27,
        LLVMDwarfTagEnumerator = 0x28,
        LLVMDwarfTagFileType = 0x29,
        LLVMDwarfTagFriend = 0x2a,
        LLVMDwarfTagNameList = 0x2b,
        LLVMDwarfTagNameListItem = 0x2c,
        LLVMDwarfTagPackedType = 0x2d,
        LLVMDwarfTagSubProgram = 0x2e,
        LLVMDwarfTagTemplateTypeParameter = 0x2f,
        LLVMDwarfTagTemplateValueParameter = 0x30,
        LLVMDwarfTagThrownType = 0x31,
        LLVMDwarfTagTryBlock = 0x32,
        LLVMDwarfTagVariantPart = 0x33,
        LLVMDwarfTagVariable = 0x34,
        LLVMDwarfTagVolatileType = 0x35,
        LLVMDwarfTagDwarfProcedure = 0x36,
        LLVMDwarfTagRestrictType = 0x37,
        LLVMDwarfTagInterfaceType = 0x38,
        LLVMDwarfTagNamespace = 0x39,
        LLVMDwarfTagImportedModule = 0x3a,
        LLVMDwarfTagUnspecifiedType = 0x3b,
        LLVMDwarfTagPartialUnit = 0x3c,
        LLVMDwarfTagImportedUnit = 0x3d,
        LLVMDwarfTagCondition = 0x3f,
        LLVMDwarfTagSharedType = 0x40,
        LLVMDwarfTagTypeUnit = 0x41,
        LLVMDwarfTagRValueReferenceType = 0x42,
        LLVMDwarfTagTemplateAlias = 0x43,

        // New in DWARF 5:
        LLVMDwarfTagCoArrayType = 0x44,
        LLVMDwarfTagGenericSubrange = 0x45,
        LLVMDwarfTagDynamicType = 0x46,

        LLVMDwarfTagMipsLoop = 0x4081,
        LLVMDwarfTagFormatLabel = 0x4101,
        LLVMDwarfTagFunctionTemplate = 0x4102,
        LLVMDwarfTagClassTemplate = 0x4103,
        LLVMDwarfTagGnuTemplateTemplateParam = 0x4106,
        LLVMDwarfTagGnuTemplateParameterPack = 0x4107,
        LLVMDwarfTagGnuFormalParameterPack = 0x4108,
        LLVMDwarfTagLoUser = 0x4080,
        LLVMDwarfTagAppleProperty = 0x4200,
        LLVMDwarfTagHiUser = 0xffff
    };
    
    // values and ordering extracted from LLVM's Attributes.inc
    // which is used to construct the Attribute::AttributeKind enumeration
    internal enum LLVMAttrKind
    {
        None,
        Alignment,
        AllocSize,
        AlwaysInline,
        ArgMemOnly,
        Builtin,
        ByVal,
        Cold,
        Convergent,
        Dereferenceable,
        DereferenceableOrNull,
        InAlloca,
        InReg,
        InaccessibleMemOnly,
        InaccessibleMemOrArgMemOnly,
        InlineHint,
        JumpTable,
        MinSize,
        Naked,
        Nest,
        NoAlias,
        NoBuiltin,
        NoCapture,
        NoDuplicate,
        NoImplicitFloat,
        NoInline,
        NoRecurse,
        NoRedZone,
        NoReturn,
        NoUnwind,
        NonLazyBind,
        NonNull,
        OptimizeForSize,
        OptimizeNone,
        ReadNone,
        ReadOnly,
        Returned,
        ReturnsTwice,
        SExt,
        SafeStack,
        SanitizeAddress,
        SanitizeMemory,
        SanitizeThread,
        StackAlignment,
        StackProtect,
        StackProtectReq,
        StackProtectStrong,
        StructRet,
        SwiftError,
        SwiftSelf,
        UWTable,
        ZExt,
    };

    internal enum LLVMMetadataKind
    {
        LLVMMetadaKindMDTuple,
        LLVMMetadaKindDILocation,
        LLVMMetadaKindGenericDINode,
        LLVMMetadaKindDISubrange,
        LLVMMetadaKindDIEnumerator,
        LLVMMetadaKindDIBasicType,
        LLVMMetadaKindDIDerivedType,
        LLVMMetadaKindDICompositeType,
        LLVMMetadaKindDISubroutineType,
        LLVMMetadaKindDIFile,
        LLVMMetadaKindDICompileUnit,
        LLVMMetadaKindDISubprogram,
        LLVMMetadaKindDILexicalBlock,
        LLVMMetadaKindDILexicalBlockFile,
        LLVMMetadaKindDINamespace,
        LLVMMetadaKindDIModule,
        LLVMMetadaKindDITemplateTypeParameter,
        LLVMMetadaKindDITemplateValueParameter,
        LLVMMetadaKindDIGlobalVariable,
        LLVMMetadaKindDILocalVariable,
        LLVMMetadaKindDIExpression,
        LLVMMetadaKindDIObjCProperty,
        LLVMMetadaKindDIImportedEntity,
        LLVMMetadaKindConstantAsMetadata,
        LLVMMetadaKindLocalAsMetadata,
        LLVMMetadaKindMDString
    };

    internal enum LLVMOptVerifierKind
    {
        LLVMOptVerifierKindNone,
        LLVMOptVerifierKindVerifyInAndOut,
        LLVMOptVerifierKindVerifyEachPass
    };

    enum LLVMTripleArchType
    {
        LlvmTripleArchType_UnknownArch,
        LlvmTripleArchType_arm,            // ARM (little endian): arm, armv.*, xscale
        LlvmTripleArchType_armeb,          // ARM (big endian): armeb
        LlvmTripleArchType_aarch64,        // AArch64 (little endian): aarch64
        LlvmTripleArchType_aarch64_be,     // AArch64 (big endian): aarch64_be
        LlvmTripleArchType_avr,            // AVR: Atmel AVR microcontroller
        LlvmTripleArchType_bpfel,          // eBPF or extended BPF or 64-bit BPF (little endian)
        LlvmTripleArchType_bpfeb,          // eBPF or extended BPF or 64-bit BPF (big endian)
        LlvmTripleArchType_hexagon,        // Hexagon: hexagon
        LlvmTripleArchType_mips,           // MIPS: mips, mipsallegrex
        LlvmTripleArchType_mipsel,         // MIPSEL: mipsel, mipsallegrexel
        LlvmTripleArchType_mips64,         // MIPS64: mips64
        LlvmTripleArchType_mips64el,       // MIPS64EL: mips64el
        LlvmTripleArchType_msp430,         // MSP430: msp430
        LlvmTripleArchType_ppc,            // PPC: powerpc
        LlvmTripleArchType_ppc64,          // PPC64: powerpc64, ppu
        LlvmTripleArchType_ppc64le,        // PPC64LE: powerpc64le
        LlvmTripleArchType_r600,           // R600: AMD GPUs HD2XXX - HD6XXX
        LlvmTripleArchType_amdgcn,         // AMDGCN: AMD GCN GPUs
        LlvmTripleArchType_sparc,          // Sparc: sparc
        LlvmTripleArchType_sparcv9,        // Sparcv9: Sparcv9
        LlvmTripleArchType_sparcel,        // Sparc: (endianness = little). NB: 'Sparcle' is a CPU variant
        LlvmTripleArchType_systemz,        // SystemZ: s390x
        LlvmTripleArchType_tce,            // TCE (http://tce.cs.tut.fi/): tce
        LlvmTripleArchType_thumb,          // Thumb (little endian): thumb, thumbv.*
        LlvmTripleArchType_thumbeb,        // Thumb (big endian): thumbeb
        LlvmTripleArchType_x86,            // X86: i[3-9]86
        LlvmTripleArchType_x86_64,         // X86-64: amd64, x86_64
        LlvmTripleArchType_xcore,          // XCore: xcore
        LlvmTripleArchType_nvptx,          // NVPTX: 32-bit
        LlvmTripleArchType_nvptx64,        // NVPTX: 64-bit
        LlvmTripleArchType_le32,           // le32: generic little-endian 32-bit CPU (PNaCl)
        LlvmTripleArchType_le64,           // le64: generic little-endian 64-bit CPU (PNaCl)
        LlvmTripleArchType_amdil,          // AMDIL
        LlvmTripleArchType_amdil64,        // AMDIL with 64-bit pointers
        LlvmTripleArchType_hsail,          // AMD HSAIL
        LlvmTripleArchType_hsail64,        // AMD HSAIL with 64-bit pointers
        LlvmTripleArchType_spir,           // SPIR: standard portable IR for OpenCL 32-bit version
        LlvmTripleArchType_spir64,         // SPIR: standard portable IR for OpenCL 64-bit version
        LlvmTripleArchType_kalimba,        // Kalimba: generic kalimba
        LlvmTripleArchType_shave,          // SHAVE: Movidius vector VLIW processors
        LlvmTripleArchType_lanai,          // Lanai: Lanai 32-bit
        LlvmTripleArchType_wasm32,         // WebAssembly with 32-bit pointers
        LlvmTripleArchType_wasm64,         // WebAssembly with 64-bit pointers
        LlvmTripleArchType_renderscript32, // 32-bit RenderScript
        LlvmTripleArchType_renderscript64, // 64-bit RenderScript
        LlvmTripleArchType_LastArchType = LlvmTripleArchType_renderscript64
    };

    enum LLVMTripleSubArchType
    {
        LlvmTripleSubArchType_NoSubArch,
        LlvmTripleSubArchType_ARMSubArch_v8_2a,
        LlvmTripleSubArchType_ARMSubArch_v8_1a,
        LlvmTripleSubArchType_ARMSubArch_v8,
        LlvmTripleSubArchType_ARMSubArch_v8m_baseline,
        LlvmTripleSubArchType_ARMSubArch_v8m_mainline,
        LlvmTripleSubArchType_ARMSubArch_v7,
        LlvmTripleSubArchType_ARMSubArch_v7em,
        LlvmTripleSubArchType_ARMSubArch_v7m,
        LlvmTripleSubArchType_ARMSubArch_v7s,
        LlvmTripleSubArchType_ARMSubArch_v7k,
        LlvmTripleSubArchType_ARMSubArch_v6,
        LlvmTripleSubArchType_ARMSubArch_v6m,
        LlvmTripleSubArchType_ARMSubArch_v6k,
        LlvmTripleSubArchType_ARMSubArch_v6t2,
        LlvmTripleSubArchType_ARMSubArch_v5,
        LlvmTripleSubArchType_ARMSubArch_v5te,
        LlvmTripleSubArchType_ARMSubArch_v4t,
        LlvmTripleSubArchType_KalimbaSubArch_v3,
        LlvmTripleSubArchType_KalimbaSubArch_v4,
        LlvmTripleSubArchType_KalimbaSubArch_v5
    };

    enum LLVMTripleVendorType
    {
        LlvmTripleVendorType_UnknownVendor,
        LlvmTripleVendorType_Apple,
        LlvmTripleVendorType_PC,
        LlvmTripleVendorType_SCEI,
        LlvmTripleVendorType_BGP,
        LlvmTripleVendorType_BGQ,
        LlvmTripleVendorType_Freescale,
        LlvmTripleVendorType_IBM,
        LlvmTripleVendorType_ImaginationTechnologies,
        LlvmTripleVendorType_MipsTechnologies,
        LlvmTripleVendorType_NVIDIA,
        LlvmTripleVendorType_CSR,
        LlvmTripleVendorType_Myriad,
        LlvmTripleVendorType_AMD,
        LlvmTripleVendorType_Mesa,
        LlvmTripleVendorType_LastVendorType = LlvmTripleVendorType_Mesa
    };

    enum LLVMTripleOSType
    {
        LlvmTripleOSType_UnknownOS,
        LlvmTripleOSType_CloudABI,
        LlvmTripleOSType_Darwin,
        LlvmTripleOSType_DragonFly,
        LlvmTripleOSType_FreeBSD,
        LlvmTripleOSType_IOS,
        LlvmTripleOSType_KFreeBSD,
        LlvmTripleOSType_Linux,
        LlvmTripleOSType_Lv2,        // PS3
        LlvmTripleOSType_MacOSX,
        LlvmTripleOSType_NetBSD,
        LlvmTripleOSType_OpenBSD,
        LlvmTripleOSType_Solaris,
        LlvmTripleOSType_Win32,
        LlvmTripleOSType_Haiku,
        LlvmTripleOSType_Minix,
        LlvmTripleOSType_RTEMS,
        LlvmTripleOSType_NaCl,       // Native Client
        LlvmTripleOSType_CNK,        // BG/P Compute-Node Kernel
        LlvmTripleOSType_Bitrig,
        LlvmTripleOSType_AIX,
        LlvmTripleOSType_CUDA,       // NVIDIA CUDA
        LlvmTripleOSType_NVCL,       // NVIDIA OpenCL
        LlvmTripleOSType_AMDHSA,     // AMD HSA Runtime
        LlvmTripleOSType_PS4,
        LlvmTripleOSType_ELFIAMCU,
        LlvmTripleOSType_TvOS,       // Apple tvOS
        LlvmTripleOSType_WatchOS,    // Apple watchOS
        LlvmTripleOSType_Mesa3D,
        LlvmTripleOSType_LastOSType = LlvmTripleOSType_Mesa3D
    };

    enum LLVMTripleEnvironmentType
    {
        LlvmTripleEnvironmentType_UnknownEnvironment,
        LlvmTripleEnvironmentType_GNU,
        LlvmTripleEnvironmentType_GNUABI64,
        LlvmTripleEnvironmentType_GNUEABI,
        LlvmTripleEnvironmentType_GNUEABIHF,
        LlvmTripleEnvironmentType_GNUX32,
        LlvmTripleEnvironmentType_CODE16,
        LlvmTripleEnvironmentType_EABI,
        LlvmTripleEnvironmentType_EABIHF,
        LlvmTripleEnvironmentType_Android,
        LlvmTripleEnvironmentType_Musl,
        LlvmTripleEnvironmentType_MuslEABI,
        LlvmTripleEnvironmentType_MuslEABIHF,
        LlvmTripleEnvironmentType_MSVC,
        LlvmTripleEnvironmentType_Itanium,
        LlvmTripleEnvironmentType_Cygnus,
        LlvmTripleEnvironmentType_AMDOpenCL,
        LlvmTripleEnvironmentType_CoreCLR,
        LlvmTripleEnvironmentType_LastEnvironmentType = LlvmTripleEnvironmentType_CoreCLR
    };

    enum LLVMTripleObjectFormatType
    {
        LlvmTripleObjectFormatType_UnknownObjectFormat,
        LlvmTripleObjectFormatType_COFF,
        LlvmTripleObjectFormatType_ELF,
        LlvmTripleObjectFormatType_MachO,
    };

    enum LLVMComdatSelectionKind
    {
        COMDAT_ANY,
        COMDAT_EXACTMATCH,
        COMDAT_LARGEST,
        COMDAT_NODUPLICATES,
        COMDAT_SAMESIZE
    };

    [System.Diagnostics.CodeAnalysis.SuppressMessage( "Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling" )]
    internal static partial class NativeMethods
    {
        [DllImport(libraryPath, EntryPoint = "LLVMGetVersionInfo", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern void GetVersionInfo(ref LLVMVersionInfo pVersionInfo);

        [DllImport( libraryPath, EntryPoint = "LLVMGetValueID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int GetValueID( LLVMValueRef @val );

        [ DllImport( libraryPath, EntryPoint = "LLVMBuildIntCast2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern LLVMValueRef BuildIntCast( InstructionBuilderHandle @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, LLVMBool isSigned, [MarshalAs( UnmanagedType.LPStr )] string @Name );

        [DllImport( libraryPath, EntryPoint = "LLVMSetDebugLoc", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void SetDebugLoc( LLVMValueRef inst, uint line, uint column, LLVMMetadataRef scope );

        [DllImport( libraryPath, EntryPoint = "LLVMSetDILocation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void SetDILocation( LLVMValueRef inst, LLVMMetadataRef location );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDILocationScope", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef /*DILocalScope*/ GetDILocationScope( LLVMMetadataRef /*DILocation*/ location );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDILocationLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 GetDILocationLine( LLVMMetadataRef /*DILocation*/ location );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDILocationColumn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 GetDILocationColumn( LLVMMetadataRef /*DILocation*/ location );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDILocationInlinedAt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef /*DILocation*/ GetDILocationInlinedAt( LLVMMetadataRef /*DILocation*/ location );

        [DllImport( libraryPath, EntryPoint = "LLVMDILocationGetInlinedAtScope", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef /*DILocalScope*/ DILocationGetInlinedAtScope( LLVMMetadataRef /*DILocation*/ location );

        [DllImport(libraryPath, EntryPoint = "LLVMVerifyFunctionEx", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool VerifyFunctionEx(LLVMValueRef @Fn, LLVMVerifierFailureAction @Action, out IntPtr @OutMessages);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAddressSanitizerFunctionPass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddAddressSanitizerFunctionPass( LLVMPassManagerRef @PM );

        [DllImport(libraryPath, EntryPoint = "LLVMAddAddressSanitizerModulePass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddAddressSanitizerModulePass( LLVMPassManagerRef @PM );

        [DllImport(libraryPath, EntryPoint = "LLVMAddThreadSanitizerPass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddThreadSanitizerPass( LLVMPassManagerRef @PM );

        [DllImport(libraryPath, EntryPoint = "LLVMAddMemorySanitizerPass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddMemorySanitizerPass( LLVMPassManagerRef @PM );

        [DllImport(libraryPath, EntryPoint = "LLVMAddDataFlowSanitizerPass", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddDataFlowSanitizerPass( LLVMPassManagerRef @PM, [MarshalAs(UnmanagedType.LPStr)] string @ABIListFile);

        [DllImport(libraryPath, EntryPoint = "LLVMAddModuleFlag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddModuleFlag(LLVMModuleRef @M, LLVMModFlagBehavior behavior, [MarshalAs(UnmanagedType.LPStr)] string @name, uint @value);

        [DllImport( libraryPath, EntryPoint = "LLVMAddModuleFlagMetadata", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AddModuleFlag( LLVMModuleRef @M, LLVMModFlagBehavior behavior, [MarshalAs( UnmanagedType.LPStr )] string @name, LLVMMetadataRef @value );

        [DllImport(libraryPath, EntryPoint = "LLVMModuleGetModuleFlagsMetadata", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMNamedMDNodeRef ModuleGetModuleFlagsMetadata( LLVMModuleRef module );

        [DllImport(libraryPath, EntryPoint = "LLVMNamedMDNodeGetNumOperands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt32 NamedMDNodeGetNumOperands( LLVMNamedMDNodeRef namedMDNode );

        [DllImport(libraryPath, EntryPoint = "LLVMNamedMDNodeGetOperand", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern /*MDNode*/ LLVMMetadataRef NamedMDNodeGetOperand( LLVMNamedMDNodeRef namedMDNode, UInt32 index );

        [DllImport(libraryPath, EntryPoint = "LLVMNamedMDNodeGetParentModule", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMModuleRef NamedMDNodeGetParentModule( LLVMNamedMDNodeRef namedMDNode );

        [DllImport( libraryPath, EntryPoint = "LLVMGetOrInsertFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef GetOrInsertFunction( LLVMModuleRef module, [MarshalAs( UnmanagedType.LPStr )] string @name, LLVMTypeRef functionType );

        [DllImport(libraryPath, EntryPoint = "LLVMIsConstantZeroValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool IsConstantZeroValue( LLVMValueRef @Val );

        [DllImport( libraryPath, EntryPoint = "LLVMRemoveGlobalFromParent", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void RemoveGlobalFromParent( LLVMValueRef @Val );

        [DllImport(libraryPath, EntryPoint = "LLVMConstantAsMetadata", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef ConstantAsMetadata( LLVMValueRef @Val );

        [DllImport(libraryPath, EntryPoint = "LLVMMDString2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef MDString2(LLVMContextRef @C, [MarshalAs(UnmanagedType.LPStr)] string @Str, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMMDNode2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef MDNode2( LLVMContextRef @C, out LLVMMetadataRef @MDs, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMTemporaryMDNode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef TemporaryMDNode( LLVMContextRef @C, out LLVMMetadataRef @MDs, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMAddNamedMetadataOperand2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void AddNamedMetadataOperand2( LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @name, LLVMMetadataRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMSetMetadata2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void SetMetadata2( LLVMValueRef @Inst, uint @KindID, LLVMMetadataRef @MD);

        [DllImport(libraryPath, EntryPoint = "LLVMMetadataReplaceAllUsesWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void MetadataReplaceAllUsesWith(LLVMMetadataRef @MD, LLVMMetadataRef @New);

        [DllImport(libraryPath, EntryPoint = "LLVMSetCurrentDebugLocation2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void SetCurrentDebugLocation2( InstructionBuilderHandle @Bref, uint @Line, uint @Col, LLVMMetadataRef @Scope, LLVMMetadataRef @InlinedAt);

        [DllImport(libraryPath, EntryPoint = "LLVMNewDIBuilder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMDIBuilderRef NewDIBuilder( LLVMModuleRef @m, LLVMBool allowUnresolved );

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderDestroy", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void DIBuilderDestroy(LLVMDIBuilderRef @d);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderFinalize", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void DIBuilderFinalize(LLVMDIBuilderRef @d);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateCompileUnit", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateCompileUnit(LLVMDIBuilderRef @D, uint @Language, [MarshalAs(UnmanagedType.LPStr)] string @File, [MarshalAs(UnmanagedType.LPStr)] string @Dir, [MarshalAs(UnmanagedType.LPStr)] string @Producer, int @Optimized, [MarshalAs(UnmanagedType.LPStr)] string @Flags, uint @RuntimeVersion);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateFile(LLVMDIBuilderRef @D, [MarshalAs(UnmanagedType.LPStr)] string @File, [MarshalAs(UnmanagedType.LPStr)] string @Dir);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateLexicalBlock", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateLexicalBlock(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, LLVMMetadataRef @File, uint @Line, uint @Column);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateLexicalBlockFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateLexicalBlockFile(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, LLVMMetadataRef @File, uint @Discriminator);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateFunction(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, [MarshalAs(UnmanagedType.LPStr)] string @LinkageName, LLVMMetadataRef @File, uint @Line, LLVMMetadataRef @CompositeType, int @IsLocalToUnit, int @IsDefinition, uint @ScopeLine, uint @Flags, int @IsOptimized, LLVMMetadataRef TParam, LLVMMetadataRef Decl );

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateTempFunctionFwdDecl", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateTempFunctionFwdDecl(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, [MarshalAs(UnmanagedType.LPStr)] string @LinkageName, LLVMMetadataRef @File, uint @Line, LLVMMetadataRef @CompositeType, int @IsLocalToUnit, int @IsDefinition, uint @ScopeLine, uint @Flags, int @IsOptimized, LLVMMetadataRef TParam, LLVMMetadataRef Decl );

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateAutoVariable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateAutoVariable(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @Line, LLVMMetadataRef @Ty, int @AlwaysPreserve, uint @Flags);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateParameterVariable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateParameterVariable(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, uint @ArgNo, LLVMMetadataRef @File, uint @Line, LLVMMetadataRef @Ty, int @AlwaysPreserve, uint @Flags);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateBasicType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateBasicType(LLVMDIBuilderRef @D, [MarshalAs(UnmanagedType.LPStr)] string @Name, ulong @SizeInBits, ulong @AlignInBits, uint @Encoding);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreatePointerType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreatePointerType(LLVMDIBuilderRef @D, LLVMMetadataRef @PointeeType, ulong @SizeInBits, ulong @AlignInBits, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateQualifiedType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateQualifiedType( LLVMDIBuilderRef Dref, uint Tag, LLVMMetadataRef BaseType );

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateSubroutineType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateSubroutineType(LLVMDIBuilderRef @D, LLVMMetadataRef @ParameterTypes, uint @Flags);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateStructType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateStructType(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @Line, ulong @SizeInBits, ulong @AlignInBits, uint @Flags, LLVMMetadataRef @DerivedFrom, LLVMMetadataRef @ElementTypes);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateUnionType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateUnionType(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @Line, ulong @SizeInBits, ulong @AlignInBits, uint @Flags, LLVMMetadataRef @ElementTypes);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateMemberType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateMemberType(LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @Line, ulong @SizeInBits, ulong @AlignInBits, ulong @OffsetInBits, uint @Flags, LLVMMetadataRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateArrayType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateArrayType(LLVMDIBuilderRef @D, ulong @SizeInBits, ulong @AlignInBits, LLVMMetadataRef @ElementType, LLVMMetadataRef @Subscripts);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateVectorType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateVectorType(LLVMDIBuilderRef @D, ulong @SizeInBits, ulong @AlignInBits, LLVMMetadataRef @ElementType, LLVMMetadataRef @Subscripts);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateTypedef", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateTypedef(LLVMDIBuilderRef @D, LLVMMetadataRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @Line, LLVMMetadataRef @Context);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderGetOrCreateSubrange", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderGetOrCreateSubrange(LLVMDIBuilderRef @D, long @Lo, long @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderGetOrCreateArray", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderGetOrCreateArray(LLVMDIBuilderRef @D, out LLVMMetadataRef @Data, ulong @Length);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderGetOrCreateTypeArray", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderGetOrCreateTypeArray(LLVMDIBuilderRef @D, out LLVMMetadataRef @Data, ulong @Length);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateExpression", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateExpression(LLVMDIBuilderRef @Dref, out long @Addr, ulong @Length);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderInsertDeclareAtEnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef DIBuilderInsertDeclareAtEnd(LLVMDIBuilderRef @D, LLVMValueRef @Storage, LLVMMetadataRef @VarInfo, LLVMMetadataRef @Expr, LLVMMetadataRef Location, LLVMBasicBlockRef @Block);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderInsertValueAtEnd", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef DIBuilderInsertValueAtEnd(LLVMDIBuilderRef @D, LLVMValueRef @Val, ulong @Offset, LLVMMetadataRef @VarInfo, LLVMMetadataRef @Expr, LLVMMetadataRef Location, LLVMBasicBlockRef @Block);

        [DllImport(libraryPath, EntryPoint = "LLVMDIBuilderCreateEnumerationType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateEnumerationType( LLVMDIBuilderRef @D, LLVMMetadataRef @Scope, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMMetadataRef @File, uint @LineNumber, ulong @SizeInBits, ulong @AlignInBits, LLVMMetadataRef @Elements, LLVMMetadataRef @UnderlyingType, [MarshalAs(UnmanagedType.LPStr)]string @UniqueId );

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderCreateEnumeratorValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateEnumeratorValue( LLVMDIBuilderRef @D, [MarshalAs(UnmanagedType.LPStr)]string @Name, long @Val );

        [DllImport( libraryPath, EntryPoint = "LLVMDIDescriptorGetTag", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMDwarfTag DIDescriptorGetTag( LLVMMetadataRef descriptor );

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderCreateGlobalVariable", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateGlobalVariable( LLVMDIBuilderRef Dref, LLVMMetadataRef Context, [MarshalAs(UnmanagedType.LPStr)] string Name, [MarshalAs(UnmanagedType.LPStr)] string LinkageName, LLVMMetadataRef File, uint LineNo, LLVMMetadataRef Ty, LLVMBool isLocalToUnit, LLVMValueRef Val, LLVMMetadataRef Decl );

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderInsertDeclareBefore", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef DIBuilderInsertDeclareBefore( LLVMDIBuilderRef Dref, LLVMValueRef Storage, LLVMMetadataRef VarInfo, LLVMMetadataRef Expr, LLVMMetadataRef Location, LLVMValueRef InsertBefore );

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderInsertValueBefore", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef DIBuilderInsertValueBefore( LLVMDIBuilderRef Dref, /*llvm::Value **/LLVMValueRef Val, UInt64 Offset, /*DILocalVariable **/ LLVMMetadataRef VarInfo, /*DIExpression **/ LLVMMetadataRef Expr, /*const DILocation **/ LLVMMetadataRef DL, /*Instruction **/ LLVMValueRef InsertBefore );

        [DllImport( libraryPath, EntryPoint = "LLVMMetadataAsString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern IntPtr MetadataAsString( LLVMMetadataRef descriptor );

        [DllImport( libraryPath, EntryPoint = "LLVMMDNodeReplaceAllUsesWith", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void MDNodeReplaceAllUsesWith( LLVMMetadataRef oldDescriptor, LLVMMetadataRef newDescriptor );

        [DllImport( libraryPath, EntryPoint = "LLVMMetadataAsValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef MetadataAsValue( LLVMContextRef context, LLVMMetadataRef metadataRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderCreateReplaceableCompositeType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateReplaceableCompositeType( LLVMDIBuilderRef Dref, uint Tag, [MarshalAs(UnmanagedType.LPStr)] string Name, LLVMMetadataRef Scope, LLVMMetadataRef File, uint Line, uint RuntimeLang, ulong SizeInBits, ulong AlignInBits, uint Flags);

        [DllImport( libraryPath, EntryPoint = "LLVMDIBuilderCreateNamespace", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DIBuilderCreateNamespace( LLVMDIBuilderRef Dref, LLVMMetadataRef scope, [MarshalAs( UnmanagedType.LPStr )] string name, LLVMMetadataRef file, uint line );

        [DllImport( libraryPath, EntryPoint = "LLVMDILocation", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DILocation( LLVMContextRef context, uint Line, uint Column, LLVMMetadataRef scope, LLVMMetadataRef InlinedAt );

        [DllImport( libraryPath, EntryPoint = "LLVMGetModuleName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern IntPtr GetModuleName( LLVMModuleRef module );

        [DllImport( libraryPath, EntryPoint = "LLVMIsTemporary", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool IsTemporary( LLVMMetadataRef M );

        [DllImport( libraryPath, EntryPoint = "LLVMIsResolved", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool IsResolved( LLVMMetadataRef M );

        [DllImport( libraryPath, EntryPoint = "LLVMIsDistinct", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool IsDistinct( LLVMMetadataRef M );

        [DllImport( libraryPath, EntryPoint = "LLVMIsUniqued", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool IsUniqued( LLVMMetadataRef M );

        [DllImport( libraryPath, EntryPoint = "LLVMGetMDStringText", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern IntPtr GetMDStringText( LLVMMetadataRef M, out uint len );

        [DllImport( libraryPath, EntryPoint = "LLVMGetGlobalAlias", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef GetGlobalAlias( LLVMModuleRef module, [MarshalAs(UnmanagedType.LPStr)] string name );

        [DllImport( libraryPath, EntryPoint = "LLVMGetAliasee", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMValueRef GetAliasee( LLVMValueRef Val );

        [DllImport( libraryPath, EntryPoint = "LLVMMDNodeResolveCycles", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern void MDNodeResolveCycles( LLVMMetadataRef M );

        [DllImport( libraryPath, EntryPoint = "LLVMSubProgramDescribes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool SubProgramDescribes( LLVMMetadataRef subProgram, LLVMValueRef function );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetLine", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt32 DITypeGetLine( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetSizeInBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt64 DITypeGetSizeInBits( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetAlignInBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt64 DITypeGetAlignInBits( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetOffsetInBits", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt64 DITypeGetOffsetInBits( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetFlags", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern UInt32 DITypeGetFlags( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetScope", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DITypeGetScope( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDITypeGetName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern IntPtr DITypeGetName( LLVMMetadataRef typeRef );

        [DllImport( libraryPath, EntryPoint = "LLVMDIScopeGetFile", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef DIScopeGetFile( LLVMMetadataRef scope );

        [DllImport( libraryPath, EntryPoint = "LLVMGetArgumentIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 GetArgumentIndex( LLVMValueRef Val );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDIFileName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr GetDIFileName( LLVMMetadataRef /*DIFile*/ file );

        [DllImport( libraryPath, EntryPoint = "LLVMGetDIFileDirectory", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr GetDIFileDirectory( LLVMMetadataRef /*DIFile*/ file );

        [DllImport( libraryPath, EntryPoint = "LLVMBuildAtomicCmpXchg", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMValueRef BuildAtomicCmpXchg( InstructionBuilderHandle @B, LLVMValueRef @Ptr, LLVMValueRef @Cmp, LLVMValueRef @New, LLVMAtomicOrdering @successOrdering, LLVMAtomicOrdering @failureOrdering, LLVMBool @singleThread );

        [DllImport( libraryPath, EntryPoint = "LLVMGetNodeContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMContextRef GetNodeContext( LLVMMetadataRef /*MDNode*/ node );

        [DllImport( libraryPath, EntryPoint = "LLVMGetMetadataID", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataKind GetMetadataID( LLVMMetadataRef /*Metadata*/ md );

        [DllImport( libraryPath, EntryPoint = "LLVMMDNodeGetNumOperands", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 MDNodeGetNumOperands( LLVMMetadataRef /*MDNode*/ node );

        [DllImport( libraryPath, EntryPoint = "LLVMMDNodeGetOperand", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMDOperandRef MDNodeGetOperand( LLVMMetadataRef /*MDNode*/ node, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMGetOperandNode", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef GetOperandNode( LLVMMDOperandRef operand );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateEmptyAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateEmptyAttributeSet( );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeSetFromKindArray", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateAttributeSetFromKindArray( LLVMContextRef context, UInt32 index, out LLVMAttrKind pKinds, UInt64 len );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeSetFromAttributeSetArray", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateAttributeSetFromAttributeSetArray( LLVMContextRef context, out UIntPtr pAttributes, UInt64 len );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeSetFromBuilder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateAttributeSetFromBuilder( LLVMContextRef context, UInt32 index, AttributeBuilderHandle bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetAddKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetAddKind( UIntPtr attributeSet, LLVMContextRef context, UInt32 index, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetAddString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetAddString( UIntPtr attributeSet, LLVMContextRef context, UInt32 index, [MarshalAs(UnmanagedType.LPStr)] string name );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetAddStringValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetAddStringValue( UIntPtr attributeSet, LLVMContextRef context, UInt32 index, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetAddAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetAddAttributes( UIntPtr attributeSet, LLVMContextRef context, UInt32 index, UIntPtr otherAttributeSet );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetRemoveAttributeKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetRemoveAttributeKind( UIntPtr attributeSet, UInt32 index, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetRemoveAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetRemoveAttributeSet( UIntPtr attributeSet, UInt32 index, UIntPtr attributes );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetRemoveAttributeBuilder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetRemoveAttributeBuilder( UIntPtr attributeSet, LLVMContextRef context, UInt32 index, AttributeBuilderHandle bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetContext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMContextRef AttributeSetGetContext( UIntPtr attributeSet );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeGetAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeGetAttributes( UIntPtr attributeSet, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetHasAttributeKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeSetHasAttributeKind( UIntPtr attributeSet, UInt32 index, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetHasStringAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeSetHasStringAttribute( UIntPtr attributeSet, UInt32 index, [MarshalAs(UnmanagedType.LPStr)] string name );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetHasAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeSetHasAttributes( UIntPtr attributeSet, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetHasAttributeSomewhere", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeSetHasAttributeSomewhere( UIntPtr attributeSet, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetAttributeByKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetGetAttributeByKind( UIntPtr attributeSet, UInt32 index, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetAttributeByName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetGetAttributeByName( UIntPtr attributeSet, UInt32 index, [MarshalAs(UnmanagedType.LPStr)] string name );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr AttributeSetToString( UIntPtr attributeSet, UInt32 index, LLVMBool inGroup );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetNumSlots", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 AttributeSetGetNumSlots( UIntPtr attributeSet );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetSlotAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetGetSlotAttributes( UIntPtr attributeSet, UInt32 slot );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetSlotIndex", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt32 AttributeSetGetSlotIndex( UIntPtr attributeSet, UInt32 slot );

        [DllImport( libraryPath, EntryPoint = "LLVMGetFunctionAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr GetFunctionAttributeSet( LLVMValueRef /*Function*/ function );

        [DllImport( libraryPath, EntryPoint = "LLVMSetFunctionAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void SetFunctionAttributeSet( LLVMValueRef /*Function*/ function, UIntPtr attributeSet );

        [DllImport( libraryPath, EntryPoint = "LLVMGetCallSiteAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr GetCallSiteAttributeSet( LLVMValueRef /*Instruction*/ instruction );

        [DllImport( libraryPath, EntryPoint = "LLVMSetCallSiteAttributeSet", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void SetCallSiteAttributeSet( LLVMValueRef /*Instruction*/ instruction, UIntPtr attributeSet );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetGetIteratorStartToken", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetGetIteratorStartToken( UIntPtr attributeSet, UInt32 slot );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeSetIteratorGetNext", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr AttributeSetIteratorGetNext( UIntPtr attributeSet, UInt32 slot, ref UIntPtr pToken );

        [DllImport( libraryPath, EntryPoint = "LLVMIsEnumAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool IsEnumAttribute( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMIsIntAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool IsIntAttribute( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMIsStringAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool IsStringAttribute( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMHasAttributeKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool HasAttributeKind( UIntPtr attribute, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMHasAttributeString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool HasAttributeString( UIntPtr attribute, [MarshalAs(UnmanagedType.LPStr)] string name );

        [DllImport( libraryPath, EntryPoint = "LLVMGetAttributeKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMAttrKind GetAttributeKind( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMGetAttributeValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UInt64 GetAttributeValue( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMGetAttributeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr GetAttributeName( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMGetAttributeStringValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr GetAttributeStringValue( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeToString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr AttributeToString( UIntPtr attribute );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateAttribute( LLVMContextRef ctx, LLVMAttrKind kind, UInt64 value );

        [DllImport( libraryPath, EntryPoint = "LVMCreateTargetDependentAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern UIntPtr CreateTargetDependentAttribute( LLVMContextRef ctx, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeBuilder", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern AttributeBuilderHandle CreateAttributeBuilder( );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeBuilder2", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern AttributeBuilderHandle CreateAttributeBuilder2( UIntPtr value );

        [DllImport( libraryPath, EntryPoint = "LLVMCreateAttributeBuilder3", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern AttributeBuilderHandle CreateAttributeBuilder3( UIntPtr attributeSet, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderDispose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderDispose( IntPtr bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderClear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderClear( AttributeBuilderHandle bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderAddEnum", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderAddEnum( AttributeBuilderHandle bldr, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderAddAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderAddAttribute( AttributeBuilderHandle bldr, UIntPtr value );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderAddStringAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderAddStringAttribute( AttributeBuilderHandle bldr, [MarshalAs(UnmanagedType.LPStr)] string  name, [MarshalAs(UnmanagedType.LPStr)] string  value );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderRemoveEnum", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderRemoveEnum( AttributeBuilderHandle bldr, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderRemoveAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderRemoveAttributes( AttributeBuilderHandle bldr, UIntPtr attributeSet, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderRemoveAttribute", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderRemoveAttribute( AttributeBuilderHandle bldr, [MarshalAs(UnmanagedType.LPStr)] string  name );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderRemoveBldr", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderRemoveBldr( AttributeBuilderHandle bldr, AttributeBuilderHandle ohter );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderMerge", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void AttributeBuilderMerge( AttributeBuilderHandle bldr, AttributeBuilderHandle ohter );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderOverlaps", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderOverlaps( AttributeBuilderHandle bldr, AttributeBuilderHandle other );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderContainsEnum", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderContainsEnum( AttributeBuilderHandle bldr, LLVMAttrKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderContainsName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderContainsName( AttributeBuilderHandle bldr, [MarshalAs(UnmanagedType.LPStr)] string  name );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderHasAnyAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderHasAnyAttributes( AttributeBuilderHandle bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderHasAttributes", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderHasAttributes( AttributeBuilderHandle bldr, UIntPtr attributeset, UInt32 index );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderHasTargetIndependentAttrs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderHasTargetIndependentAttrs( AttributeBuilderHandle bldr );

        [DllImport( libraryPath, EntryPoint = "LLVMAttributeBuilderHasTargetDependentAttrs", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool AttributeBuilderHasTargetDependentAttrs( AttributeBuilderHandle bldr );

        [DllImport(libraryPath, EntryPoint = "LLVMDILocalScopeGetSubProgram", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMMetadataRef DILocalScopeGetSubProgram(LLVMMetadataRef /*DILocalScope*/ localScope);

        [DllImport( libraryPath, EntryPoint = "LLVMFunctionGetSubprogram", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMMetadataRef FunctionGetSubprogram( LLVMValueRef function );

        [DllImport( libraryPath, EntryPoint = "LLVMFunctionSetSubprogram", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void FunctionSetSubprogram( LLVMValueRef function, LLVMMetadataRef subprogram );

        [DllImport(libraryPath, EntryPoint = "LLVMFunctionHasPersonalityFunction", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern LLVMBool FunctionHasPersonalityFunction( LLVMValueRef function );

        [DllImport( libraryPath, EntryPoint = "LLVMCreatePassRegistry", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern PassRegistryHandle CreatePassRegistry( );

        [DllImport( libraryPath, EntryPoint = "LLVMPassRegistryDispose", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void PassRegistryDispose( IntPtr hPassRegistry );

        [DllImport( libraryPath, EntryPoint = "LLVMRunPassPipeline", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool RunPassPipeline( LLVMContextRef context, LLVMModuleRef M, LLVMTargetMachineRef TM, [MarshalAs( UnmanagedType.LPStr )] string passPipeline, LLVMOptVerifierKind VK, [MarshalAs(UnmanagedType.Bool)] bool ShouldPreserveAssemblyUseListOrder, [MarshalAs( UnmanagedType.Bool )] bool ShouldPreserveBitcodeUseListOrder );

        [DllImport( libraryPath, EntryPoint = "LLVMInitializeCodeGenForOpt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void InitializeCodeGenForOpt( PassRegistryHandle R );

        [DllImport( libraryPath, EntryPoint = "LLVMInitializePassesForLegacyOpt", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void InitializePassesForLegacyOpt( );

        [DllImport( libraryPath, EntryPoint = "LLVMRunLegacyOptimizer", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void RunLegacyOptimizer( LLVMModuleRef Mref, LLVMTargetMachineRef TMref );

        [DllImport( libraryPath, EntryPoint = "LLVMParseTriple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern TripleHandle ParseTriple( [MarshalAs( UnmanagedType.LPStr )] string triple );

        [DllImport( libraryPath, EntryPoint = "LLVMDisposeTriple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void DisposeTriple( IntPtr triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleOpEqual", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool TripleOpEqual( TripleHandle lhs, TripleHandle rhs );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetArchType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleArchType TripleGetArchType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetSubArchType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleSubArchType TripleGetSubArchType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetVendorType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleVendorType TripleGetVendorType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetOsType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleOSType TripleGetOsType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleHasEnvironment", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMBool TripleHasEnvironment( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetEnvironmentType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleEnvironmentType TripleGetEnvironmentType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetEnvironmentVersion", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void TripleGetEnvironmentVersion( TripleHandle triple, out UInt32 major, out UInt32 minor, out UInt32 micro );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetObjectFormatType", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMTripleObjectFormatType TripleGetObjectFormatType( TripleHandle triple );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleAsString", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleAsString( TripleHandle triple, [MarshalAs(UnmanagedType.U1)]bool normalize );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetArchTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetArchTypeName( LLVMTripleArchType type );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetSubArchTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetSubArchTypeName( LLVMTripleSubArchType type );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetVendorTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetVendorTypeName( LLVMTripleVendorType vendor );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetOsTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetOsTypeName( LLVMTripleOSType osType );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetEnvironmentTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetEnvironmentTypeName( LLVMTripleEnvironmentType environmentType );

        [DllImport( libraryPath, EntryPoint = "LLVMTripleGetObjectFormatTypeName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr TripleGetObjectFormatTypeName( LLVMTripleObjectFormatType environmentType );

        [DllImport( libraryPath, EntryPoint = "LLVMNormalizeTriple", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr NormalizeTriple( [MarshalAs( UnmanagedType.LPStr )] string triple );

        [UnmanagedFunctionPointer( System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal delegate bool ComdatIteratorCallback( LLVMComdatRef comdatRef );

        [DllImport( libraryPath, EntryPoint = "LLVMModuleEnumerateComdats", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void ModuleEnumerateComdats( LLVMModuleRef module, ComdatIteratorCallback callback );

        [DllImport( libraryPath, EntryPoint = "LLVMModuleInsertOrUpdateComdat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMComdatRef ModuleInsertOrUpdateComdat( LLVMModuleRef module, [MarshalAs( UnmanagedType.LPStr )] string name, LLVMComdatSelectionKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMModuleComdatRemove", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void ModuleComdatRemove( LLVMModuleRef module, LLVMComdatRef comdatRef );

        [DllImport( libraryPath, EntryPoint = "LLVMModuleComdatClear", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void ModuleComdatClear( LLVMModuleRef module );

        [DllImport( libraryPath, EntryPoint = "LLVMGlobalObjectGetComdat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMComdatRef GlobalObjectGetComdat( LLVMValueRef Val );

        [DllImport( libraryPath, EntryPoint = "LLVMGlobalObjectSetComdat", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void GlobalObjectSetComdat( LLVMValueRef Val, LLVMComdatRef comdatRef );

        [DllImport( libraryPath, EntryPoint = "LLVMComdatGetKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern LLVMComdatSelectionKind ComdatGetKind( LLVMComdatRef comdatRef );

        [DllImport( libraryPath, EntryPoint = "LLVMComdatSetKind", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern void ComdatSetKind( LLVMComdatRef comdatRef, LLVMComdatSelectionKind kind );

        [DllImport( libraryPath, EntryPoint = "LLVMComdatGetName", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, BestFitMapping = false, ThrowOnUnmappableChar = true )]
        internal static extern IntPtr ComdatGetName( LLVMComdatRef comdatRef );
    }
}
