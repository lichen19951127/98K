﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseNet_98K.IDAL
{
    using Entity;
    /// <summary>
    /// ** 描述：稿费DAL接口
    /// ** 创始时间：2018-12-2
    /// ** 修改时间：-
    /// ** 作者：lc
    /// </summary>
    public interface IProfits_DAL:IBase_DAL<Profits>
    {
        /// <summary>
        /// 获取稿费信息
        /// </summary>
        /// <returns></returns>
        List<Profits> Query();
    }
}
