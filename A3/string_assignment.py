def check_codes(filename):
    good_codes = []
    bad_codes = []
    product_codes = open(filename, 'r')
    for code in product_codes:
        if check_code_length(code) & check_code_country(code) & check_code_security(code):
            good_codes.append(code)
        else:
            bad_codes.append(code)
    print("Valid Code(s) are: ")
    print_codes(good_codes)

    print("Invalid Code(s) are: ")
    print_codes(bad_codes)

    restricted_codes = check_restricted_codes(good_codes)
    print("Invalid Restricted Code(s) are: ")
    print_codes(restricted_codes)

    return


# Helper Functions
# Prints the list of codes
def print_codes(code_list):
    for x in code_list:
        print(x)
    return


# Checks to see if the code is at least 10 characters long
def check_code_length(code):
    if len(code) >= 10:
        return True
    else:
        return False


# Checks to see characters 4 through 7 are digits
def check_code_country(code):
    if code[3:7].isdigit():
        return True
    else:
        return False


# Checks that character 10 is a capital letter
def check_code_security(code):
    if code[9].isupper():
        return True
    else:
        return False


# Checks to see if the code is prohibited under new government laws
def check_restricted_codes(code_list):
    r_codes = []
    for c in code_list:
        # Checks if the security level is restricted and country code is above 2000
        if (str(c[9]) == "R") & (int(c[3:7]) >= 2000):
            r_codes.append(c)
    return r_codes


def main():
    check_codes("A3 Codes.txt")


main()
