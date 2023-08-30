<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642930/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4192)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Dock Layout Manager - Animate DocumentPanels in MDI Mode

This example animates [DocumentPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel) in [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) in Multi-Document Interface (MDI) mode. To create animation effects, create an implicit style for the [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel). This style uses triggers that are set to the following properties to run the animation:

- IsMaximized
- IsMinimized
- Closed

![](./wpf-dock-layout-manager-animate-documentgroups.gif)

## Files to Look At

* [MainWindow.xaml](./CS/DocumentGroup_MDI_Ex/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DocumentGroup_MDI_Ex/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DocumentGroup_MDI_Ex/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DocumentGroup_MDI_Ex/MainWindow.xaml.vb))

## Documentation

- [Multiple-Document Interface (MDI)](https://docs.devexpress.com/WPF/7209)
