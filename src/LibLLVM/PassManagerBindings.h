//===- InstrumentationBindings.h - instrumentation bindings -----*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//
//
// This file defines C bindings for the Transforms/Instrumentation component.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_BINDINGS_LLVM_INSTRUMENTATIONBINDINGS_H
#define LLVM_BINDINGS_LLVM_INSTRUMENTATIONBINDINGS_H

#include "llvm-c/Core.h"

#ifdef __cplusplus
extern "C" {
#endif

// FIXME: These bindings shouldn't be language binding-specific and should eventually move to
// a (somewhat) less stable collection of C APIs for use in creating bindings of
// LLVM in other languages.

void LLVMAddAddressSanitizerFunctionPass(LLVMPassManagerRef PM);
void LLVMAddAddressSanitizerModulePass(LLVMPassManagerRef PM);
void LLVMAddThreadSanitizerPass(LLVMPassManagerRef PM);
void LLVMAddMemorySanitizerPass(LLVMPassManagerRef PM);
void LLVMAddDataFlowSanitizerPass( LLVMPassManagerRef PM, int ABIListFilesNum, const char **ABIListFiles );

LLVMPassRegistryRef LLVMCreatePassRegistry( );
void LLVMPassRegistryDispose( LLVMPassRegistryRef passReg );

// For  optimization codegen passes, only passes that do IR to IR transformation are
// used.
void LLVMInitializeCodeGenForOpt( LLVMPassRegistryRef R );

#ifdef __cplusplus
}
#endif

#endif
