package controller;

import jakarta.servlet.annotation.*;
import jakarta.servlet.http.*;
import jakarta.servlet.*;
import javax.mail.MessagingException;
import java.io.*;

import java.util.*;
import business.*;
import util.*;
import data.UserDB;

@WebServlet(urlPatterns="/bs")
public class bsController extends HttpServlet {
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) 
            throws ServletException, IOException {
        
        String url = "/admin.jsp";
        ServletContext sc = getServletContext();
        String requestURI = request.getRequestURI();
        String action = request.getParameter("action");
        log("action = " + action);

        if (requestURI.endsWith("/bs")) {
            action = request.getParameter("action");
            if (action == null || action.isEmpty()) {
                List<User> users = UserDB.selectUsers();
                request.setAttribute("users", users);
                url = "/admin.jsp";
            } else if (action.equals("update")) {
                String userName = request.getParameter("userName");
                String email = request.getParameter("email");
                String addr = request.getParameter("addr");  // Corrected parameter name
                String phoneNo = request.getParameter("phoneNo");

                String message;
                if (email == null || email.isEmpty()) {
                    message = "Failed to update the user because the email text box is empty.";
                } else {
                    User user = UserDB.selectUser(email);
                    if (userName != null && !userName.isEmpty()) {
                        user.setUserName(userName);
                    }
                    if (addr != null && !addr.isEmpty()) {
                        user.setAddr(addr);
                    }
                    if (phoneNo != null && !phoneNo.isEmpty()) {
                        user.setPhoneNo(phoneNo);
                    }

                    UserDB.update(user);
                    message = "Successfully updated the user.";
                }

                List<User> users = UserDB.selectUsers();
                request.setAttribute("users", users);
                request.setAttribute("message", message);
            } else if (action.equals("delete")) {
                String email = request.getParameter("email");
                String message;
                if (email == null || email.isEmpty()) {
                    message = "Failed to delete the user because the email text box is empty.";
                } else if ("andi@murach.com".equalsIgnoreCase(email) || 
                           "joelmurach@yahoo.com".equalsIgnoreCase(email) || 
                           "mike@murach.com".equalsIgnoreCase(email)) {
                    message = "Cannot delete this user.";
                } else {
                    User user = UserDB.selectUser(email);
                    UserDB.delete(user);
                    message = "Successfully deleted the user and associated information.";
                }

                List<User> users = UserDB.selectUsers();
                request.setAttribute("users", users);
                request.setAttribute("message", message);
            } else if (action.equals("insert")) {
                String userName = request.getParameter("userName");
                String email = request.getParameter("email");
                String addr = request.getParameter("addr");
                String phoneNo = request.getParameter("phoneNo");

                String message;
                if (userName == null || email == null || addr == null || phoneNo == null
                        || userName.isEmpty() || email.isEmpty() || addr.isEmpty() || phoneNo.isEmpty()) {
                    message = "Please fill out all four text boxes.";
                } else if (UserDB.emailExists(email)) {
                    message = "This email address already exists. Please enter another email address.";
                } else {
                    User user = new User(userName, email, addr, phoneNo);
                    UserDB.insert(user);
                    message = "Successfully inserted the user.";
                }

                List<User> users = UserDB.selectUsers();
                request.setAttribute("users", users);
                request.setAttribute("message", message);
            }
        }

        sc.getRequestDispatcher(url).forward(request, response);
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) 
            throws ServletException, IOException {
        doPost(request, response);
    }
}
