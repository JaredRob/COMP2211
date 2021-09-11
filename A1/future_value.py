# Future value formula is F = P x (1 + i)^t

# Request inputs from the user
pv = float(input("Please enter the present value of the account: "))
rate = float(input("Please enter the monthly interest rate: "))
months_i = int(input("Please enter the number of months the money will be left in the account: "))


# Define future value formula function
def future_value(present_value, interest_rate, months):
    # Returns the Future Value calculated from the inputs
    return present_value * (1 + interest_rate) ** months


# Prints the resultant Future Value of the account to the user.
print("Based on your above inputs, your account will have ${:.2f} in {} months.".format(future_value(pv, rate,months_i), months_i))
