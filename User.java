Class {
    String UserID;
    String Password;
    String Email;
    String UserType;

    public static void CreateUser(String UserID, String Password, String Email, String UserType) {
        this.UserID = UserID;
        this.Password = Password;
        this.Email = Email;
        this.UserType = UserType;
    }
    public static void ResetPassword(String UserID, String Password) {
        this.UserID = UserID;
        this.Password = Password;
    }
}