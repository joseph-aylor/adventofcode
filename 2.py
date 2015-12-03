class Package:
    def __init__(self, length, width, height):
        self.length = int(length)
        self.width = int(width)
        self.height = int(height)

    def wrapping_paper_area(self):
        sides = [(self.length * self.width), (self.width * self.height), (self.height * self.length)]
        slack = min(sides)
        return reduce(lambda x, y: x + y, [2 * s for s in sides]) + slack

    def ribbon_length(self):
        bow = self.length * self.width * self.height

        sides = [self.length, self.width, self.height]

        smallest_side = min(sides)
        sides.remove(smallest_side)

        second_smallest_side = min(sides)

        length = 2 * (smallest_side + second_smallest_side)

        return length + bow


with open("2.input") as input:
    total_square_feet = 0
    total_ribbon_feet = 0
    for line in input:
        args = line.rstrip().split("x")
        package = Package(*args)
        total_square_feet += package.wrapping_paper_area()
        total_ribbon_feet += package.ribbon_length()

print "{} square feet of wrapping paper {} feet of ribbon".format(total_square_feet, total_ribbon_feet)
