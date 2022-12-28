<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task.aspx.cs" Inherits="_28_12.task" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="Styles/sweetalert.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/sweetalert.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
</head>
 
<body style="background-color:#d94125;">
    <form id="form1" runat="server">
         
                  <div>
            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>  <%--/  وجودها اساسي عشان يشتغل agax control /--%>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">             <%--/ حاويه يتم فيها تحديث البيانات فقط من غير تحديث باقي الصفحة  /--%>
                        <ContentTemplate>
                 <section style="background-color: #d94125;">
  <div class="container my-5 py-5 text-dark">
    <div class="row d-flex justify-content-center">
      <div class="col-md-10 col-lg-8 col-xl-6">
        <div class="card">
          <div class="card-body p-4">
            <div class="d-flex flex-start w-100">
              <img class="rounded-circle shadow-1-strong me-3"
                src="https://mdbcdn.b-cdn.net/img/Photos/Avatars/img%20(21).webp" alt="avatar" width="65"
                height="65" />
              <div class="w-100">
                <h3>Add a comment</h3>
                  <br />
                <div class="form-outline">
                    <asp:TextBox ID="TextBox2" runat="server" class="form-control"  rows="4"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Fill All Feilds"
                        ControlToValidate="TextBox2" SetFocusOnError="true" style="color:red;">*</asp:RequiredFieldValidator>
               <%--   <textarea  ID="TextBox2"  runat="server" ></textarea>--%> <br />
                  <label class="form-label" for="textAreaExample">What is your view?</label>
                </div>
                <div class="d-flex justify-content-between mt-3">
                      <asp:Button ID="Button1" runat="server" Text="Send"  class="btn btn-danger" OnClientClick="successalert" OnClick="Button1_Click"/>
                  <i class="fas fa-long-arrow-alt-right ms-1"></i>
                  </button>
                </div>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>  
                             </ContentTemplate>
                </asp:UpdatePanel>
                 <script type="text/javascript">
                     function successalert() {
                         swal({
                             title: 'Congratulations!',
                             text: 'Your comment has been succesfully sent',
                             type: 'success'
                         });
                     }
                 </script>
        </div>
    </form>
</body>
</html>
