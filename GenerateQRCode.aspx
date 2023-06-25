<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateQRCode.aspx.cs" Inherits="GenerateQRCode.GenerateQRCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="lib/bootstrap/css/publicstyle.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1"    style="direction:rtl; padding:70px 70px ;"   runat="server">

                          
        <table>
            <tr>


                <td  >
                    <asp:Label ID="Label12" runat="server" class="labelclass" Text="از تاریخ / از شماره سند"></asp:Label>

                    </
                </td>


                <td  >
                    <asp:TextBox ID="SearchValue" runat="server" class="inputclass"></asp:TextBox>
                </td>


            </tr>


            <tr>

                  <td>
                      
                            
                </td>


                   <td>
                       <div  style="align-content:center;">

                               <asp:ImageButton ID="BtnGenerateQRCode" runat="server" class="bigbuttonstyle" ImageUrl="lib/bootstrap/Image/QR.jpg"
                                       OnClick="BtnGenerateQRCode_Click" />
                       </div>
                    
                </td>
            </tr>
        

        </table>
                       

                  
        <asp:Image ID="ImageGeneratedBarcode" runat="server" CssClass="img-thumbnail" Visible="false"/>
     
    </form>
</body>

</html>

