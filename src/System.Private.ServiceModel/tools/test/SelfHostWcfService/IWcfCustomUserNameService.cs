﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


using System;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    internal interface IWcfCustomUserNameService
    {
        [OperationContract(Action = "http://tempuri.org/IWcfCustomUserNameService/Echo")]
        String Echo(String message);
    }
}
