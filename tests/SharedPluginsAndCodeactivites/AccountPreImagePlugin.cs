﻿// <copyright file="AccountUpdateErpFigures.cs" company="">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author></author>
// <date>1/26/2015 1:55:15 PM</date>
// <summary>Implements the AccountUpdateErpFigures Plugin.</summary>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
// </auto-generated>


using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;

namespace DG.Some.Namespace {

    /// <summary>
    /// AccountUpdateErpFigures Plugin.
    /// Fires when the following attributes are updated:
    /// All Attributes
    /// </summary>    
    public class AccountPreImagePlugin : Plugin {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPreImagePlugin"/> class.
        /// </summary>
        public AccountPreImagePlugin() : base(typeof(AccountPreImagePlugin)) {
            RegisterPluginStep<Account>(
                EventOperation.Delete,
                ExecutionStage.PostOperation,
                ExecuteAccountUpdateErpFigures)
                  .SetExecutionMode(ExecutionMode.Synchronous)
                  .AddImage(ImageType.PreImage,
                    a => a.ParentAccountId);

        }

        /// <summary>
        /// Executes the plug-in.
        /// </summary>
        /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
        /// <see cref="IPluginExecutionContext"/>,
        /// <see cref="IOrganizationService"/>
        /// and <see cref="ITracingService"/>
        /// </param>
        /// <remarks>
        /// For improved performance, Microsoft Dynamics CRM caches plug-in instances.
        /// The plug-in's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the plug-in. Also, multiple system threads
        /// could execute the plug-in at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        protected void ExecuteAccountUpdateErpFigures(LocalPluginContext localContext) {
          
        }
    }
}
