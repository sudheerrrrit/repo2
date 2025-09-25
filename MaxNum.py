def Maxi():
    num1 = int(input("Enter a number: "))
    num2 = int(input("Enter a number: "))
    if(num1 > num2):
        return num1
    return num2
res = Maxi()
print(res)