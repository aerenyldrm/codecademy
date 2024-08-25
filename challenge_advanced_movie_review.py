def movie_review(rating):
    if rating <= 5: return "AVOID AT ENTIRE COSTS!"
    elif rating < 9: return "THIS IS FUN."
    else: return "OUTSTANDING!"

print(movie_review(9))
print(movie_review(4))
print(movie_review(6))