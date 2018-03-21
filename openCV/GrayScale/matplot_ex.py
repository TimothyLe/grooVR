import cv2
import numpy as np
import matplotlib.pyplot as plt
#				0
# Converts the pixels to gray shades
img = cv2.imread('ping.jpg', cv2.IMREAD_GRAYSCALE) 
# IMREAD_COLOR = 1
# IMREAD_UNCHANGED = -1

# oenCV does BGR
# matplotlib does RGB

# Coordinates of image for analysis
plt.imshow(img, cmap='gray', interpolation='bicubic')
# Plots a cyan line
plt.plot([50,100],[80,100], 'c', lineWidth=5)
plt.show()

# Saves image into directory
# cv2.imwrite('gray_pic.png', img)