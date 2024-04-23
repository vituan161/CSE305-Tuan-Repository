import List;
Class {
    List<User> ListOfUser;

    public static void AddUser(User user) {
        ListOfUser.add(user);
    }
    public static void removeUser(User user) {
        ListOfUser.remove(user);
    }
}