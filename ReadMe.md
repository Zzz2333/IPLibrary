﻿本项目功能是根据IP查询归属地。用到了纯真IP地址数据库，即`qqwry.dat`文件。

纯真IP地址数据库是一个网上流行的、免费的IP地址库。以下是官方介绍：

>收集了包括中国电信、中国移动、中国联通、长城宽带、聚友宽带等 ISP 的 IP 地址数据，包括网吧数据。希望能够通过大家的共同努力打造一个没有未知数据，没有错误数据的QQ IP。IP数据库每5天更新一次，请大家定期更新IP数据库！

从介绍中可以看到，这个IP库是**每隔5天更新**的，所以我们使用的时候也要注意定期更新。

该IP库是附带在官方工具下的，下载官方提供的安装包（下载地址见后文），安装后，在安装目录即可看到`qqwry.dat`文件。`qqwry.dat`文件是压缩后的IP数据库，通过提供的官方工具，在界面点击“解压”按钮，即可以把该二进制文件解压成可读的txt文件（虽然文件后缀名还是dat）。 我们开发的话，直接拿到此文件，自己编程进行读取、查询即可。另外，点击官方工具界面上的“在线升级”按钮，即可更新`qqwry.dat`文件。

关于`qqwry.dat`的结构和解析，网上找到一篇博文写得不错，见下文链接地址。本项目基于此实现。

另外，上传的项目文件中还包含了已经下载好的官方工具的安装包，安装后即可使用。见项目目录下的`IP归属地查询工具.zip`。

参考资料：
[IP库官方地址](http://www.cz88.net/fox)
[qqwry.dat的数据结构图文解释](https://www.jb51.net/article/17197_all.htm)