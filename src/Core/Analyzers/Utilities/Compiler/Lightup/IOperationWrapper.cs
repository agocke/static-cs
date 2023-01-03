﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

namespace Analyzer.Utilities.Lightup
{
    using Microsoft.CodeAnalysis;

    internal interface IOperationWrapper
    {
        IOperation? WrappedOperation { get; }
    }
}