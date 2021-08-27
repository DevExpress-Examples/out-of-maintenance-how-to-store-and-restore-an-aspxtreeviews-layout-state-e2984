<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128565330/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2984)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to store and restore an ASPxTreeView's layout state
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2984/)**
<!-- run online end -->


<p>This example shows how to store an ASPxTreeView's layout state (which shows which nodes are expanded, which ones are not) and restore it. The ASPxTreeView is in <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8575"><u>Virtual Mode</u></a>.<br />
Also, note the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeViewASPxTreeView_ExpandedChangingtopic"><u>ASPxTreeView.ExpandedChanging</u></a>'s event handler. It is empty, but if we remove it, the ASPxTreeView will not send server requests on a node collapsing, and its new layout state will not be stored in this case.</p>

<br/>


