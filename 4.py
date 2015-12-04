import md5

hasher = md5.new()

input = 'ckczppom'
correctprefix = '000000'

coinid = 1

hasher.update(input + str(coinid))

while not hasher.hexdigest().startswith(correctprefix):
    coinid = coinid + 1
    hasher = md5.new()
    hasher.update(input + str(coinid))

print coinid
