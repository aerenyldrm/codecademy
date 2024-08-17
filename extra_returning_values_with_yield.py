# function to produce infinite fibonacci numbers
def fibonacci():
    # generate first number
    a = 1
    yield a

    # generate second number
    b = 1
    yield b

    # infinite loop
    while True:
        # return sum of a + b
        c = a + b
        yield c
        # function resumes loop here on next call
        a = b
        b = c

# iterate through the fibonacci sequence until a limit is reached
for number in fibonacci():
    if number > 55:
        break
    print(number)