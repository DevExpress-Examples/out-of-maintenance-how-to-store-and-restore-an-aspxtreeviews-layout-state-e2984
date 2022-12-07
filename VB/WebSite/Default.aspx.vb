Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web
Imports System.Collections.Generic

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub virtualTree_VirtualModeCreateChildren(ByVal source As Object, ByVal e As TreeViewVirtualModeCreateChildrenEventArgs)
		Dim children As New List(Of TreeViewVirtualNode)()

		If e.NodeName Is Nothing Then
			AppendChildNode(children, "me", "Me!", False)
			AppendChildNode(children, "family", "Family", False)
			AppendChildNode(children, "friends", "Friends", False)
		Else
			If e.NodeName = "me" Then
				AppendChildNode(children, "clean", "Cleaning")
				AppendChildNode(children, "drive", "Driving", False)
				AppendChildNode(children, "play", "Playing")
			ElseIf e.NodeName = "family" Then
				AppendChildNode(children, "anthony", "Anthony", False)
				AppendChildNode(children, "chris", "Chris")
			ElseIf e.NodeName = "friends" Then
				AppendChildNode(children, "john", "John", False)
				AppendChildNode(children, "ram", "Ram")
			ElseIf e.NodeName = "drive" Then
				AppendChildNode(children, "crv", "CRV")
				AppendChildNode(children, "bmw", "BMW")
				AppendChildNode(children, "kluger", "Kluger")
			ElseIf e.NodeName = "anthony" Then
				AppendChildNode(children, "run", "Running")
				AppendChildNode(children, "swim", "Swimming")
			ElseIf e.NodeName = "john" Then
				AppendChildNode(children, "read", "Reading")
				AppendChildNode(children, "test", "Testing")
			End If
		End If
		e.Children = children
	End Sub

	Protected Sub virtualTree_ClientLayout(ByVal sender As Object, ByVal e As ASPxClientLayoutArgs)
		If e.LayoutMode = ClientLayoutMode.Loading Then
			If Session("layout") IsNot Nothing Then
				e.LayoutData = Session("layout").ToString()
			End If
		Else
			Session("layout") = e.LayoutData
		End If
	End Sub
	Private Sub AppendChildNode(ByVal nodeList As IList(Of TreeViewVirtualNode), ByVal nodeName As String, ByVal nodeText As String)
		AppendChildNode(nodeList, nodeName, nodeText, True)
	End Sub
	Private Sub AppendChildNode(ByVal nodeList As IList(Of TreeViewVirtualNode), ByVal nodeName As String, ByVal nodeText As String, ByVal isLeaf As Boolean)
		Dim node As New TreeViewVirtualNode(nodeName, nodeText)
		node.IsLeaf = isLeaf
		nodeList.Add(node)

	End Sub
	Protected Sub virtualTree_ExpandedChanging(ByVal source As Object, ByVal e As TreeViewNodeCancelEventArgs)

	End Sub
End Class

