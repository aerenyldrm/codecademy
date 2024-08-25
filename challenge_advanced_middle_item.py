def middle_element(my_list):
  length = len(my_list)
  if length % 2 == 0: middle = int(length / 2); return (my_list[middle - 1] + my_list[middle]) / 2
  else: middle = length // 2; return my_list[middle]

print(middle_element([5, 2, -10, -4, 4, 5]))