import random
# above is necceary libraries
name = "Eren"
question = "Is it probable?"
reply = ""
random_number = random.randint(1, 10)
# above are required variables
if random_number == 1: reply = "Yes - definitely"
elif random_number == 2: reply = "It is decidedly so"
elif random_number == 3: reply = "Without a doubt"
elif random_number == 4: reply = "Reply hazy, try again"
elif random_number == 5: reply = "Ask again later"
elif random_number == 6: reply = "Better not to tell you now"
elif random_number == 7: reply = "My sources say no"
elif random_number == 8: reply = "Outlook not so good"
elif random_number == 9: reply = "Very doubtful"
elif random_number == 10: reply = "It is not about your happiness"
# above are control flow
else:
  reply = "Error"
# above is error handling
if question == "": print("Please provide a question")
else:
# above are about whether question variable is there or not
  if name == "": print("Question:", question)
  else: print(name, "questions:", question)
  print("Magic 8-Ball's reply:", reply)
  # above are about whether name variable is there or not