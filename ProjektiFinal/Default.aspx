<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="ProjektiFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <img src="images/uni.png" /> 
    </div>

    <h1>Fakulteti i Ekonomisë</h1>
    
    <h2 aria-atomic="False">Portali i regjistrimit për studentët</h2>
    <div class="div1">
        <asp:Label runat="server" Text="Emri*:">
        </asp:Label>
        <asp:TextBox runat="server" ID="txt_emri" placeholder="Emri juaj" ></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="req" controltovalidate="txt_emri" errormessage="Required!" Style="color:red" />

        <asp:Label runat="server" Text="Mbiemri*:"></asp:Label>
        <asp:TextBox runat="server" ID="txt_mbiemri" placeholder="Mbiemri juaj" ></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" id="req2" controltovalidate="txt_mbiemri" errormessage="Required!" Style="color:red"/>
    </div>

    <div class="div2">
        <asp:Label runat="server"  Text="Koha e plotesimit te dokumentit*:"></asp:Label>
        <asp:Calendar runat="server" ID="cal_koha" TextAlign="Right" Style="list-style=center; background-color:gold;" align="center" ></asp:Calendar>
    </div>
    <div class="div3">
        <asp:Label Text="Gjinia*:" runat="server"></asp:Label>
        <asp:RadioButtonList runat="server" ID="rdb_gjinia" Width="152px" TextAlign="Right" Style="list-style=center" align="center">
            <asp:ListItem Text="Femer" Value="1"></asp:ListItem>
            <asp:ListItem Text="Mashkull" Value="2"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator runat="server" id="req3" controltovalidate="rdb_gjinia" errormessage="Required!" Style="color:red"/>
    </div>
    <div class="div4">
        <asp:Label runat="server" Text="Dega e Studimit*:"></asp:Label>
        <asp:DropDownList ID="ddl_dega" runat="server">
            <asp:ListItem Text="Administrim Biznes" Value="1"></asp:ListItem>
            <asp:ListItem Text="Ekonomiks" Value="2"></asp:ListItem>
            <asp:ListItem Text="Finance Kontabilitet" Value="3"></asp:ListItem>
            <asp:ListItem Text="Informatike Ekonomike" Value="4"></asp:ListItem>
       </asp:DropDownList> 
    </div>
    <div class="div5">
        <asp:Label runat="server" Text="Emaili juaj*:"></asp:Label>
        <asp:TextBox runat="server" placeholder="Emaili juaj" ID="txt_email"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txt_email" ErrorMessage="Email jo i rregullt"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator runat="server" id="req5" controltovalidate="txt_email" errormessage="Required!" Style="color:red" />
        </div>
    <div class="div7">
        <asp:LinkButton runat="server" CssClass="btn-primary" Text="Shtoni te dhenat:" ID="lbt_shto" OnClick="lbt_shto_Click" TextAlign="Right" Style="list-style=center" align="center" />
    </div>
    <div>
        <asp:GridView runat="server" ID="gv_tabela" AutoGenerateColumns="true" Width="100%"  ViewStateMode="Enabled" Style="background-color:salmon; color:dodgerblue;">
            <Columns>
                
            </Columns>
        </asp:GridView>
        </div>
    <div class="div6">
        <asp:Label runat="server" Text="Ngarkoni diplomen e gjimnazit*:"></asp:Label>
        <asp:FileUpload runat="server" ID="FileUpload1" CssClass="fut" />
    </div>
    
    
    <div class="div9">
         <asp:LinkButton ID="lbn_export" runat="server" Text="Eksporto ne PDF" OnClick="lbn_exportToPdf_Click" TextAlign="Right" Style="align-items:center"></asp:LinkButton>
        <asp:LinkButton ID="lbn_sendemail" runat="server" Text="Send email" OnClick="lbn_sendemail_Click" TextAlign="Right" Style="align-items:center; margin-left:45px;"></asp:LinkButton>
    </div>
    <div>
       
    </div>
    
</asp:Content>