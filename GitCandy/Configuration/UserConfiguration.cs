﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using NewLife.Xml;

namespace GitCandy.Configuration
{
    [XmlConfigFile("Config\\Git.Config", 15000)]
    public class UserConfiguration : XmlConfig<UserConfiguration>
    {
        #region 属性
        /// <summary>开放服务</summary>
        [DisplayName("开放服务")]
        public bool IsPublicServer { get; set; } = true;

        /// <summary>强制SSL</summary>
        [DisplayName("强制SSL")]
        public bool ForceSsl { get; set; }

        /// <summary>SSL端口</summary>
        [DisplayName("SSL端口")]
        public int SslPort { get; set; } = 443;

        /// <summary>开启SSH</summary>
        [DisplayName("开启SSH")]
        public bool EnableSsh { get; set; } = true;

        /// <summary>SSH端口</summary>
        [DisplayName("SSH端口")]
        public int SshPort { get; set; } = 22;

        /// <summary>跳过本地错误</summary>
        [DisplayName("跳过本地错误")]
        public bool LocalSkipCustomError { get; set; }

        /// <summary>允许注册</summary>
        [DisplayName("允许注册")]
        public bool AllowRegisterUser { get; set; } = true;

        /// <summary>允许创建代码库</summary>
        [DisplayName("允许创建代码库")]
        public bool AllowRepositoryCreation { get; set; } = true;

        /// <summary>代码库存储路径</summary>
        [DisplayName("代码库存储路径")]
        public String RepositoryPath { get; set; } = "..\\Repos";

        /// <summary>缓存路径</summary>
        [DisplayName("缓存路径")]
        public String CachePath { get; set; } = "..\\Cache";

        /// <summary>Git-Core路径</summary>
        [DisplayName("Git-Core路径")]
        public String GitCorePath { get; set; }

        /// <summary>每页提交数</summary>
        [DisplayName("每页提交数")]
        public int Commits { get; set; } = 30;

        /// <summary>分页大小</summary>
        [DisplayName("分页大小")]
        public int PageSize { get; set; } = 30;

        /// <summary>显示参与者数</summary>
        [DisplayName("显示参与者数")]
        public int Contributors { get; set; } = 50;

        public List<HostKey> HostKeys { get; set; } = new List<HostKey>();
        #endregion

        public UserConfiguration()
        {
        }

        protected override void OnNew()
        {
            GitCorePath = GetGitCore();

            base.OnNew();
        }

        private String GetGitCore()
        {
            var list = new List<String>();
            var variable = Environment.GetEnvironmentVariable("path");
            if (variable != null)
                list.AddRange(variable.Split(';'));

            list.Add(Environment.GetEnvironmentVariable("ProgramW6432"));
            list.Add(Environment.GetEnvironmentVariable("ProgramFiles"));

            foreach (var drive in Environment.GetLogicalDrives())
            {
                list.Add(drive + @"Program Files\Git");
                list.Add(drive + @"Program Files (x86)\Git");
                list.Add(drive + @"Program Files\PortableGit");
                list.Add(drive + @"Program Files (x86)\PortableGit");
                list.Add(drive + @"PortableGit");
            }

            list = list.Where(x => !String.IsNullOrEmpty(x)).Distinct().ToList();
            foreach (var path in list)
            {
                var ret = SearchPath(path);
                if (ret != null)
                    return ret;
            }

            return "";
        }

        private String SearchPath(String path)
        {
            var patterns = new[] {
                @"..\libexec\git-core", // git 1.x
                @"libexec\git-core", // git 1.x
                @"..\mingw64\libexec\git-core", // git 2.x
                @"mingw64\libexec\git-core", // git 2.x
            };
            foreach (var pattern in patterns)
            {
                var fullpath = new DirectoryInfo(Path.Combine(path, pattern)).FullName;
                if (File.Exists(Path.Combine(fullpath, "git.exe"))
                    && File.Exists(Path.Combine(fullpath, "git-receive-pack.exe"))
                    && File.Exists(Path.Combine(fullpath, "git-upload-archive.exe"))
                    && File.Exists(Path.Combine(fullpath, "git-upload-pack.exe")))
                    return fullpath;
            }
            return null;
        }
    }
}