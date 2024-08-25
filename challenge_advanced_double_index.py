def double_index(my_list, index):
    length_check = len(my_list)
    if index >= length_check or index < - length_check: return my_list
    else: my_list[index] *= 2; return my_list

print(double_index([3, 8, -10, 12], 2))