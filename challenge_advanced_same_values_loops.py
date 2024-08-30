def same_values(list_1, list_2):
    same_values_indices = []
    for counter in range(len(list_1)):
        if list_1[counter] == list_2[counter]: same_values_indices.append(counter)
    return same_values_indices

print(same_values([5, 1, -10, 3, 3], [5, 10, -10, 3, 5]))