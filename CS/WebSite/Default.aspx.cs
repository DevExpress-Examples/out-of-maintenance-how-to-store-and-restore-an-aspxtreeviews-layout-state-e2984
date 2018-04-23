using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxClasses;
using DevExpress.Web.ASPxTreeView;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page {

	protected void virtualTree_VirtualModeCreateChildren(object source, TreeViewVirtualModeCreateChildrenEventArgs e) {
		List<TreeViewVirtualNode> children = new List<TreeViewVirtualNode>();

		if (e.NodeName == null) {
			AppendChildNode(children, "me", "Me!", false);
			AppendChildNode(children, "family", "Family", false);
			AppendChildNode(children, "friends", "Friends", false);
		}
		else {
			if (e.NodeName == "me") {
				AppendChildNode(children, "clean", "Cleaning");
				AppendChildNode(children, "drive", "Driving", false);
				AppendChildNode(children, "play", "Playing");				
			}			
			else if (e.NodeName == "family") {
				AppendChildNode(children, "anthony", "Anthony", false);
				AppendChildNode(children, "chris", "Chris");				
			}
			else if (e.NodeName == "friends") {
				AppendChildNode(children, "john", "John", false);
				AppendChildNode(children, "ram", "Ram");
			}
			else if (e.NodeName == "drive") {
				AppendChildNode(children, "crv", "CRV");
				AppendChildNode(children, "bmw", "BMW");
				AppendChildNode(children, "kluger", "Kluger");				
			}
			else if (e.NodeName == "anthony") {
				AppendChildNode(children, "run", "Running");
				AppendChildNode(children, "swim", "Swimming");				
			}
			else if (e.NodeName == "john") {
				AppendChildNode(children, "read", "Reading");
				AppendChildNode(children, "test", "Testing");
			}
		}
		e.Children = children;
	}

	protected void virtualTree_ClientLayout(object sender, ASPxClientLayoutArgs e) {
		if (e.LayoutMode == ClientLayoutMode.Loading) {
			if (Session["layout"] != null)
				e.LayoutData = Session["layout"].ToString();
		}
		else {
			Session["layout"] = e.LayoutData;
		}
	}
	private void AppendChildNode(IList<TreeViewVirtualNode> nodeList, string nodeName, string nodeText) {
		AppendChildNode(nodeList, nodeName, nodeText, true);
	}
	private void AppendChildNode(IList<TreeViewVirtualNode> nodeList, string nodeName, string nodeText, bool isLeaf) {
		TreeViewVirtualNode node = new TreeViewVirtualNode(nodeName, nodeText);
		node.IsLeaf = isLeaf;
		nodeList.Add(node);

	}
	protected void virtualTree_ExpandedChanging(object source, TreeViewNodeCancelEventArgs e) {

	}
}

