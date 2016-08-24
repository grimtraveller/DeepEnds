﻿//------------------------------------------------------------------------------
// <copyright file="SourceProvider.cs" company="Zebedee Mason">
//     Copyright (c) 2016 Zebedee Mason.
//
//      The author's copyright is expressed through the following notice, thus
//      giving effective rights to copy and use this software to anyone, as shown
//      in the license text.
//
//     NOTICE:
//      This software is released under the terms of the GNU Lesser General Public
//      license; a copy of the text has been released with this package (see file
//      LICENSE, where the license text also appears), and can be found on the
//      GNU web site, at the following address:
//
//           http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html
//
//      Please refer to the license text for any license information. This notice
//      has to be considered part of the license, and should be kept on every copy
//      integral or modified, of the source files. The removal of the reference to
//      the license will be considered an infringement of the license itself.
// </copyright>
//------------------------------------------------------------------------------

namespace DeepEnds.CSharp
{
    using Microsoft.CodeAnalysis.CSharp;

    public class SourceProvider : DeepEnds.Core.SourceProvider
    {
        private string project;

        public SourceProvider(DeepEnds.Core.Dependent.Dependency node, string project, string filePath)
            : base(node, filePath)
        {
            this.project = project;
        }

        public override bool Move(DeepEnds.Core.Dependent.Dependency branch)
        {
            return true;
        }
    }
}
