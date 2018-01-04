<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="Sample.Email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
    <style>
        body {
            background-image: url(image/AboutMe2.jpg);
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">

    <!-- Main component for a primary marketing message or call to action -->
    <!-- Container (Contact Section) -->
    <br />
    <br />
    <br />
    <div class="container ">
        <h2 class="text-center">CONTACT</h2>
        <div class="row">
            <div class="col-sm-5">
                <p>Contact me and I'll get back to you within 24 hours.</p>
                <p><span class="glyphicon glyphicon-map-marker"></span>South Bend, IN</p>
                <p><span class="glyphicon glyphicon-phone"></span>1-416-828-0000</p>
                <p><span class="glyphicon glyphicon-envelope"></span><a href="mailto:admin@minheedev.com">admin@minheedev.com</a></p>
            </div>
            <div class="col-sm-7">

                <div class="group">
                    <input type="text" id="name" runat="server" required="required" />
                    <span class="highlight"></span>
                    <span class="bar"></span>
                    <label>Name</label>
                </div>

                <div class="group">
                    <input type="email" id="emailFrom" runat="server" required="required" />
                    <span class="highlight"></span>
                    <span class="bar"></span>
                    <label>Email</label>
                </div>

                <div class="group">

                    <textarea id="comments" runat="server" rows="2"></textarea>
                    <span class="highlight"></span>
                    <span class="bar"></span>
                    <label>Message</label>
                </div>
                                <div class="group">
                    <asp:Button ID="sendEmail" runat="server" class="btn btn-default pull-right" OnClick="emailSubmit_click" Text="Send Message" />

                </div>

            </div>

        </div>

    </div>



</asp:Content>
