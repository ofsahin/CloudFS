﻿/*
The MIT License(MIT)

Copyright(c) 2015 IgorSoft

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Globalization;
using System.IO;

namespace IgorSoft.CloudFS.Interface.IO
{
    [System.Diagnostics.DebuggerDisplay("{DebuggerDisplay(),nq}")]
    public class DirectoryInfoContract : FileSystemInfoContract
    {
        public new DirectoryId Id => (DirectoryId)base.Id;

        public DirectoryInfoContract Parent { get; set; }

        public override string FullName => (Parent?.FullName ?? string.Empty) + Name + Path.DirectorySeparatorChar;

        public override string Mode => "d----";

        public DirectoryInfoContract(string id, string name, DateTimeOffset created, DateTimeOffset updated) : base(new DirectoryId(id), name, created, updated)
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Debugger Display")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private string DebuggerDisplay() => $"{nameof(DirectoryInfoContract)} {Id} ({Name})".ToString(CultureInfo.CurrentCulture);
    }
}
