def add_greetings(names):
    for counter in range(len(names)): names[counter] = "Greeting " + names[counter] + '!'
    return names

print(add_greetings(["Owen", "Max", "Sophie"]))