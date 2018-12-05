﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Model
{
    public class BPFile
    {
        /// <summary>
        /// BPId
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 上传源文件的地址
        /// </summary>
        public string OriginFilePath { get; set; }

        /// <summary>
        /// 格式转换后的文件地址
        /// </summary>
        public string FromatFilePath { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}
