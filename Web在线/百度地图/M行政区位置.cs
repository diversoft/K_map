﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    [Serializable]
    public class M行政区位置
    {
        public static List<string> 直辖市 = new List<string> { "北京市", "天津市", "上海市", "重庆市" };

        //省直辖县级行政区划//自治区直辖县级行政区划

        public string 省 { get; set; }
        
        public string 市 { get; set; }
        
        public string 区 { get; set; }
        
        public double 经度 { get; set; }

        public double 纬度 { get; set; }

        public string 边界坐标 { get; set; }

        public string 描述 {
            get
            {
                if (直辖市.Contains(市))
                {
                    if (区 == 市 || string.IsNullOrEmpty(区))
                    {
                        return 省;
                    }
                    return 市 + 区;
                }
                if (市 == 省 || string.IsNullOrEmpty(市))
                {
                    return 省;
                }
                if (区 == 市 || string.IsNullOrEmpty(区))
                {
                    return 市;
                }
                if (区.EndsWith("市") || 区.EndsWith("县"))
                {
                    return 区;
                }
                return 市.Replace("省直辖县级行政区划", "").Replace("自治区直辖县级行政区划", "") + 区;
            }
        }

        public string 序列化()
        {
            var __描述 = new StringBuilder();
            __描述.Append(省).Append(",");
            __描述.Append(市).Append(",");
            __描述.Append(区).Append(",");
            __描述.Append(经度).Append(",");
            __描述.Append(纬度).Append(",");
            __描述.Append(边界坐标);
            return __描述.ToString();
        }
    }

    
}
