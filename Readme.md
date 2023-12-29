<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to store and restore an ASPxTreeView's layout state


<p>This example shows how to store an ASPxTreeView's layout state (which shows which nodes are expanded, which ones are not) and restore it. The ASPxTreeView is in <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8575"><u>Virtual Mode</u></a>.<br />
Also, note the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeViewASPxTreeView_ExpandedChangingtopic"><u>ASPxTreeView.ExpandedChanging</u></a>'s event handler. It is empty, but if we remove it, the ASPxTreeView will not send server requests on a node collapsing, and its new layout state will not be stored in this case.</p>

<br/>


