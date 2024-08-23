def max_num(num_1, num_2, num_3):
  if num_1 > num_2 and num_1 > num_3: return num_1
  elif num_2 > num_1 and num_2 > num_3: return num_2
  elif num_3 > num_1 and num_3 > num_2: return num_3
  else: return "A TIE!"

print(max_num(-10, 0, 10))
print(max_num(-10, 5, -30))
print(max_num(-5, -10, -10))
print(max_num(2, 3, 3))