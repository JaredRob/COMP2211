def main():
    # Obtain the students first 3 letters of their first name
    first_name = str(input("Enter your first name: "))
    first_name = first_name[0:3]

    # Obtain the students first 3 letters of their last name
    last_name = str(input("Enter your last name: "))
    last_name = last_name[0:3]

    # Obtain the students first 3 letters of their student ID
    s_id = str(input("Enter your student ID: "))
    s_id = s_id[0:3]

    # Call login info function
    student_login = get_login_name(first_name, last_name, s_id)
    print("Your student login is: " + student_login + "\n")

    password = str(input(
        "Please create a password satisfying the following conditions: \n" + "- be at least seven characters long \n" + "- have at least one uppercase letter \n" + "- have at least one lowercase letter \n" + "- have at least one digit: "))
    check_password(password)


# Define Get Login info function
def get_login_name(f_name, l_name, student_id):
    # Concatenates the students first name, last name and, student id
    return f_name + l_name + student_id


# Define the password checking function
def check_password(password):
    # Define our counters
    capital_check = 0
    lower_check = 0
    digit_check = 0

    # Check if the password violates one of the conditions
    if len(password) < 7:
        print("Your password must be at least seven characters long.")
    for x in password:
        if x.isupper():
            capital_check += 1
        elif x.islower():
            lower_check += 1
        elif x.isdigit():
            digit_check += 1

    # Inform the user where their password was wrong
    if capital_check == 0:
        print("Your password must contain a capital letter.")

    if lower_check == 0:
        print("Your password must contain a lowercase letter.")

    if digit_check == 0:
        print("Your password contain a digit.")

    # Inform the user of a successful password creation
    if (capital_check >= 1) & (lower_check >= 1) & (digit_check >= 1) & (len(password) >= 7):
        print("Your password was successfully recorded!")


main()
