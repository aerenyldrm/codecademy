def odd_indices(my_list):
    odd_indices_values = []
    for counter in range(len(my_list)):
        if counter % 2 == 1: odd_indices_values.append(my_list[counter])
    return odd_indices_values

print(odd_indices([4, 3, 7, 10, 11, -2]))