Message Application Project

This project is a messaging application developed using C# and SQL. It allows users to log in, create new accounts, send messages, and view received and sent messages. The application is designed with a user-friendly interface and includes the following features:

Features
- Login Screen: Users can log in using their number and password. There is also an option for users without an account to create a new one.
- New Account Screen: Users can create an account by entering their name, surname, and password. The system automatically assigns a number, which is displayed on the account creation screen.
- All Messages Screen: Main screen contains the following;
  - Inbox: Displays messages sent to the user in a DataGridView.
  - Sent Items: Shows the messages that the user has sent.
  - New Message Screen: Opens a form to write a new message, where the receiver's number, message title, and content are entered. After sending the message, the user can return to the main screen using the back button.
  - My Account Screen: A form where users can view, update their profile details (name, surname, and password; except for the number) using the 'Update' and delete their accounts using the 'Delete' button. After doing any of these actions, users can return to the main page using the 'Return to the Messages Screen' button.
  - Sign Out: The user logs out and returns to the login screen.

Database Structure
- People Table: Stores user details, including ID, name, surname, number, and password.
- Message Table: Stores message details, including message ID, the receiver and sender's number, message subject and text.

Usage
- Run the application.
- Log in using your number and password, or click the link label to create a new account.
- View the inbox to see received messages or check the sent items for messages you have sent.
- Use the 'New Message' button to send a message by entering the receiver’s number, message subject and content.
- Click 'My Account' to view and update your profile information or delete your account.
- Use the 'Logout' button to log out and return to the login screen.

Requirements
- .NET Framework.
- SQL Server or an appropriate database driver for database connection.

![1](https://github.com/user-attachments/assets/1a7666dc-4d8e-4980-958d-cc3bbc7cf9fb)
![6](https://github.com/user-attachments/assets/5089a3a3-5f80-45e8-ab80-342943c4ef4c)
![2](https://github.com/user-attachments/assets/3d911f04-dfdb-41d2-b477-e988343e096c)
![3](https://github.com/user-attachments/assets/8255bee6-75bf-485d-9865-d0ebe20c89ab)
![4](https://github.com/user-attachments/assets/aa3a4710-689e-44dc-8a21-22ad4dd4f628)
![5](https://github.com/user-attachments/assets/86fd97a6-d772-48c0-82ab-84b1ae0690ce)
![7](https://github.com/user-attachments/assets/e785911a-f3af-442a-a00a-0c293e006874)
