import cv2
import numpy as numpy

cap = cv2.VideoCapture(1)

while True:
	_, frame = cap.read()

	# Data type for age gradients
	laplacian = cv2.Laplacian(frame, cv2.CV_64F)
	# Directional intensity with gradients
	sobelx = cv2.Sobel(frame, cv2.CV_64F, 1, 0, ksize=5)
	sobely = cv2.Sobel(frame, cv2.CV_64F, 0, 1, ksize=5)
	# Edge detectors
	# The greater the value of the parameters, the less overlapping edges
	edges = cv2.Canny(frame, 100, 100)

	# Window for real-time capture
	cv2.imshow('original', frame)
	# Windows for gradient effect
	cv2.imshow('laplacian', laplacian)
	# X-direction gradient
	cv2.imshow('sobelx', sobelx)
	# Y-direction gradient
	cv2.imshow('sobely', sobely)
	# Display edges
	cv2.imshow('edges', edges)

	# ESC key to quit program
	k = cv2.waitKey(5) & 0xFF
	if k == 27:
		break

# Let go of camera and windows to proceed with other tasks simultaneously
cv2.destroyAllWindows()
cap.release()