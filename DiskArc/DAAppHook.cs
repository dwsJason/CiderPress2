﻿/*
 * Copyright 2022 faddenSoft
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;

namespace DiskArc {
    public static class DAAppHook {
        //
        // Option name constants.  These are simple strings, but we want to use constants
        // so the compiler will catch typographical errors.  These may be supplied from the
        // command line (--set-int), so keep the names reasonable.
        //

        // Make "marked but unused" allocations a warning, rather than just an informational
        // message.  This is primarily for the benefit of the DiskArc test suite.
        public const string WARN_MARKED_BUT_UNUSED = "warn-marked-but-unused";

        // When scanning a DOS catalog, stop at the first unused entry.  (This should always be
        // true unless the catalog is weird.)
        public const string DOS_STOP_FIRST_UNUSED = "dos-stop-first-unused";

        // Root directory when running library tests.  This is where "TestData" can be found.
        public const string LIB_TEST_ROOT = "lib-test-root";

        // Override the standard T17 S0 location of the DOS VTOC.
        // This is documented as a command-line arg; do not rename.
        public const string DOS_VTOC_TRACK = "dos-vtoc-track";
        public const string DOS_VTOC_SECTOR = "dos-vtoc-sector";

        // Override the default compression choice when adding files to NuFX archives.
        public const string NUFX_COMP_ALG = "nufx-comp-alg";

        // Audio cassette decoder algorithm.  Ideally this would be passed in directly, but
        // it's a semi-experimental facet of a rarely-used feature, so plumbing it all the
        // way through isn't worthwhile.
        // This is documented as a command-line arg; do not rename.
        public const string AUDIO_DEC_ALG = "audio-dec-alg";
    }
}
