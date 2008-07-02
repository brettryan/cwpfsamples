﻿//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory
//===============================================================================
// Copyright (C) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BrettRyan.LateNight.Services {

    /// <summary>
    ///
    /// </summary>
    public abstract class AbstractEntityTranslator : IEntityTranslator {

        #region IEntityTranslator Members

        public abstract bool CanTranslate(Type targetType, Type sourceType);

        public bool CanTranslate<TTarget, TSource>() {
            return CanTranslate(typeof(TTarget), typeof(TSource));
        }

        public abstract object Translate(
            IEntityTranslatorService service, Type targetType, object source);

        public TTarget Translate<TTarget>(IEntityTranslatorService service, object source) {
            return (TTarget)Translate(service, typeof(TTarget), source);
        }

        #endregion

    }

}

