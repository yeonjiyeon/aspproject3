using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevValidationControl
{
    public partial class rmRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // SetFocus() 메서드 : 아이디 텍스트박스에 포커스
                Page.SetFocus(txtUserId);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // IsValid 속성 : 유효성 검사가 통과되면 true를 반환
            if (Page.IsValid)
            {
                Page.ClientScript.RegisterClientScriptBlock(
                    /*
                    Page.ClientScript.RegisterClientScriptBlock() 메서드는 특정 자바스크립트 코드를 실행하는 기능을 하는데 첫 번째 매개 변수의 값은 기본이다. 
                    두 번째 매개 변수의 값은 자바스크립트 코드에 대한 구분자를 넣어준다. 
                    마지막 매개 변수의 값은 <script> 태그를 포함한 자바스크립트 코드가 들어온다.
                     */
                    this.GetType(),
                    "alertMessage",
                    "<script>alert('통과');</script>");
            }
        }
    }
}