using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string father = txtFather.Text;
        string mother = txtMother.Text;
        string  phone = txtPhone.Text;
        string email = txtEmail.Text;
        string address = txtEmail.Text;
        string gender = chkGender.Text;
        string dob = txtDob.Text;
        string blood_grp = ddBloodgrp.Text;
        string department = departmentList.Text;
        string course = courses.Text;
        //filePhoto.HasFile
        if(String.IsNullOrEmpty(name)){
            errName.InnerText = "Please enter name!";
        }else if(String.IsNullOrEmpty(father)){
            errFather.InnerText = "Please enter father's name!";
        }else if(String.IsNullOrEmpty(mother)){
            errMother.InnerText = "Please enter mother's name!";
        }else if(String.IsNullOrEmpty(phone)){
            errPhone.InnerText = "Please enter phone number!";
        }else if(String.IsNullOrEmpty(email)){
            errEmail.InnerText = "Please enter email!";
        }else if(String.IsNullOrEmpty(address)){
            errAddress.InnerText = "Please enter address!";
        }else if(String.IsNullOrEmpty(gender)){
            errGender.InnerText = "Please select a gender!";
        }else if(String.IsNullOrEmpty(dob)){
            errDob.InnerText = "Please set the date of birth!";
        }else if(String.IsNullOrEmpty(blood_grp)){
            errBloodgrp.InnerText = "Please select blood group!";
        }else if(String.IsNullOrEmpty(department)){
            errDepartment.InnerText = "Please select department!";
        }else if(String.IsNullOrEmpty(course)){
            errCourse.InnerText = "Please select the course!";
        }else if(filePhoto.HasFile == false){
            errPhoto.InnerText = "Please upload your photo!";
        }else{
            regSuccess.InnerText = "User Registered Successfully!";
        }
    }
}
