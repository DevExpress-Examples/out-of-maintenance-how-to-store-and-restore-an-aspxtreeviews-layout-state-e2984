<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxTreeView" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>How to store and restore an ASPxTreeView's layout state</title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<br />
			<br />
			<dx:ASPxTreeView ID="virtualTree" runat="server" OnVirtualModeCreateChildren="virtualTree_VirtualModeCreateChildren"
				OnClientLayout="virtualTree_ClientLayout" OnExpandedChanging="virtualTree_ExpandedChanging">
			</dx:ASPxTreeView>
		</div>
		<br />
		<a href="Default.aspx">Refresh page</a>
	</form>
</body>
</html>