﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlReaderForm.aspx.cs" Inherits="_07.XmlReader.XmlReaderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormMain" runat="server">
        <asp:XmlDataSource ID="XmlDataSourceBooks" runat="server" DataFile="~/simple-books.xml" XPath="/catalog/book">
        </asp:XmlDataSource>
        <asp:TreeView runat="server" ID="TreeViewXmlData" DataSourceID="XmlDataSourceBooks" AutoGenerateDataBindings="False" 
            LineImagesFolder="~/TreeLineImages" ShowLines="True" MaxDataBindDepth="2">
            <DataBindings>
                <asp:TreeNodeBinding  DataMember="book" Value="parent" Text="Book"/>
                <asp:TreeNodeBinding  DataMember="author" TextField="#InnerText"/>
                <asp:TreeNodeBinding  DataMember="title" TextField="#InnerText"/>
                <asp:TreeNodeBinding  DataMember="isbn" TextField="#InnerText"/>
                <asp:TreeNodeBinding  DataMember="price" TextField="#InnerText"/>  
                <asp:TreeNodeBinding  DataMember="web-site" TextField="#InnerText"/>          
            </DataBindings>
        </asp:TreeView>        
    </form>
</body>
</html>
