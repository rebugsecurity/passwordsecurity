using System;

class PasswordSecuritySoftware {
    static void Main(string[] args) {
        Console.WriteLine("Please enter your password:");

        // Read the user's input as a string
        string password = Console.ReadLine();

        // Check if password meets requirements
        if (IsValidPassword(password)) {
            Console.WriteLine("Your password is strong and secure!");
        } else {
            Console.WriteLine("Your password is not strong enough.");
        }

        Console.ReadKey();
    }

    static bool IsValidPassword(string password) {
        // Password length must be at least 8 characters
        if (password.Length < 8) {
            return false;
        }

        // Password must contain at least one uppercase letter, one lowercase letter, and one number
        bool hasUppercase = false;
        bool hasLowercase = false;
        bool hasNumber = false;

        foreach (char c in password) {
            if (Char.IsUpper(c)) {
                hasUppercase = true;
            } else if (Char.IsLower(c)) {
                hasLowercase = true;
            } else if (Char.IsDigit(c)) {
                hasNumber = true;
            }
        }

        if (!hasUppercase || !hasLowercase || !hasNumber) {
            return false;
        }

        // Password is considered strong and secure
        return true;
    }
}