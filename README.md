<div align="center">

![LOGO](./Ink-Canvas-Reborn-Logo.png)

# Ink Canvas Reborn

[直接下载](https://github.com/dubi906w/Ink-Canvas-Reborn/releases/latest "Latest Releases") | [使用指南](https://github.com/dubi906w/Ink-Canvas-Reborn/blob/master/MANUAL.md "说明和指南") | [常见问题](https://github.com/dubi906w/Ink-Canvas-Reborn#FAQ "FAQ") | [English](./README-EN.md)

[![交流群](https://img.shields.io/badge/-%E4%BA%A4%E6%B5%81%E7%BE%A4%20195404368-blue?style=flat&logo=TencentQQ)](https://qm.qq.com/q/PDfJCGLqwM)  ![GitHub issues](https://img.shields.io/github/issues/dubi906w/Ink-Canvas-Reborn?logo=github)

A fantastic Ink Canvas in WPF/C#, with fantastic support for Seewo Boards.

学校从传统投影仪换成了希沃白板，由于自带的“希沃白板”软件太难用，也没有同类好用的画板软件，所以 [WXRIW](https://github.com/WXRIW) 开发了该画板。

但是由于 [WXRIW](https://github.com/WXRIW) 已经从高中毕业了，该项目的开发近于停滞，为了修复部分陈年Bug，于是 `dubi906w` 重构了本画板软件。

</div>

## 👀 前言

使用和分发本软件（软件名称：Ink Canvas Reborn）前，请您应当且务必知晓相关开源协议，本软件基于 [WXRIW/Ink-Canvas](https://github.com/WXRIW/Ink-Canvas) 修改而成。

**⚠️ 警告：** dubi906w 不对使用本软件所造成的任何损失承担责任！

## 🔧 特性

- 对 Microsoft PowerPoint 和 WPS Office 有优化支持。
- **笔细的一头写字，反过来粗的一头是橡皮擦。（希沃白板并不支持）**
- 优化原版 Ink Canvas 手掌擦除墨迹的体验。
- 手绘的 **几何形状** 可以落笔后自动转换成 **印刷体** 。
- 完全重写 Ink Canvas 原版项目，添加众多新功能，添加 UI 交互动画，升级界面外观，同时也会修复大量问题，并优化使用逻辑与提升用户体验

## ℹ️ 提示

- 提问前请先读 [FAQ](https://github.com/WXRIW/Ink-Canvas#FAQ)
- 遇到问题请先尝试自行解决，若无法自行解决，请简单描述你的期望与现实的差异性。如果有必要，请附上复现此问题的操作步骤或错误日志¹ （可适当配图），等待回复。
- 对新功能的有效意见和合理建议，开发者会适时回复并进行开发。Ink Canvas 并非商业性质的软件，请勿催促开发者，耐心才能让功能更少BUG、更加稳定。

> 等待是人类的一种智慧

 [1] ：对于长文本，可以使用在线剪贴板 （如 https://pastes.dev/ ），粘贴完毕点击 `SAVE` 后复制链接进行分享
 
## 📗 FAQ

### 点击放映后一翻页就闪退？
考虑是由于 `Microsoft Office` 未激活导致的，请自行激活

### 放映后画板程序不会切换到 PPT 模式？
如果你曾经安装过 `WPS Office` 且在卸载后发现此问题，则是由于 32 位 Office 的 COM 接口被 `WPS Office` 覆盖（没有被卸载程序清理干净）的原因，重新安装完整的 `Office 2016 Mondo x86` 版本后即可解决。

另外，处在保护（只读）模式的PPT不会被识别

同时，请确保 `Microsoft PowerPoint` 或者 `WPS Office` 和 `Ink Canvas` 运行在同一权限下。不同的权限可能也会导致画板程序无法切换到 PPT 模式。

### 安装后程序无法正常启动？
请检查你的电脑上是否安装了 `.Net Framework 4.7.2` 或更高版本。若没有，请前往官网下载  

如果仍无法运行，请检查你的电脑上是否安装了 `Microsoft Office`。若没有，请安装后重试

### 我该在何处提出功能需求和错误报告？

1. GitHub Issues

    功能需求：https://github.com/dubi906w/Ink-Canvas-Reborn/labels/enhancement/new 

    错误报告：https://github.com/dubi906w/Ink-Canvas-Reborn/labels/bug/new

2. Tencent QQ&nbsp;&nbsp;[![交流群](https://img.shields.io/badge/-%E4%BA%A4%E6%B5%81%E7%BE%A4%20195404368-blue?style=flat&logo=TencentQQ)](https://qm.qq.com/q/PDfJCGLqwM)

### 大小屏设备交替使用/手指或笔头过大 导致被识别成橡皮怎么办？
点击画板的 `设置` 按钮并开启 `特殊屏幕` 选项即可，或关闭 `使用白板笔的触摸面积检测手势橡皮` 选项。


## 🙏 感谢
感谢 [yuwenhui2020](https://github.com/yuwenhui2020) 为 `Ink Canvas 使用说明` 做出的贡献！  

感谢 [WXRIW](https://github.com/WXRIW)、[Raspberry Kan](https://github.com/Raspberry-Monster)、[Kengwang](https://github.com/kengwang)、[Charles Jia](https://github.com/jiajiaxd)、[clover_yan](https://github.com/clover-yan)、[Netherite_Bowl](https://github.com/NetheriteBowl)、[Yoojun Zhou](https://github.com/NotYoojun)、[ZongziTEK](https://github.com/STBBRD)、[ChangSakura](https://github.com/ChangSakura) 为原项目贡献代码！

感谢 [InkCanvas/InkCanvasForClass](https://github.com/InkCanvas/InkCanvasForClass)、[SketchNow/SketchNow.WPF](https://github.com/SketchNow/SketchNow.WPF) 和 [Alan-CRL/Inkeys](https://github.com/Alan-CRL/Inkeys) 为该项目的发展所做出的贡献！

## ✅ 许可证

GPL-3.0 license

---

过去的就过了吧，icc 终究只是过去。 **逗比再也没有了。**

`dubi906w` 指本软件的开发者，和拥有 `逗比的九百有六大不留`、`Doubx690i`、`kriastans` 等称谓的用户与开发者无任何关系，只是故意同名。
