import cv2 as cv
import numpy as np
import time

# Note: Might need to run in terminal:
# `DISPLAY=:0.0 ; export DISPLAY`

# Cascades are huge XML files with features sets for facial profiles and other items

face_cascade = cv.CascadeClassifier('haarcascade_frontalface_default.xml')

eye_cascade = cv.CascadeClassifier('haarcascade_eye.xml')

# Correct ID is 0
cap = cv.VideoCapture(0)

# Check if capture is open 
print(cap.isOpened())

time.sleep(5)

while (cap.isOpened()):
	ret, img = cap.read()
	print(ret)
	# Convert image to gray immediately
	gray = cv.cvtColor(img, cv.COLOR_BGR2GRAY)
	# Figures for detecting gray
	faces = face_cascade.detectMultiScale(gray, 1.3, 5) # works without second and third parameter
	# Treats image as 2D matrix
	for (x,y,w,h) in faces:
		# Detects eyes within region of the face
		cv.rectangle(img, (x,y), (x+w, y+h), (255,0,0), 2)
		# Region of face
		roi_gray = gray[y:y+h, x:x+w]
		# Reimpose previous statement with brightness
		roi_color = img[y:y+h, x:x+w]
		eyes = eye_cascade.detectMultiScale(roi_gray)
		for (ex, ey, ew, eh) in eyes:
			# Draws rectangles capturing eyes
			cv.rectangle(roi_color, (ex, ey), (ex+ew,ey+eh), (0,255,0), 2)
	# Image output
	cv.imshow('img', img)
	k = cv.waitKey(30) & 0xff
	# Press the ESC key
	if k == 27:
		break

# Release the video camera to allow other processes to run or access via another task
cap.release()
# Release windows to run python application
cv.destroyAllWindows()

# Note: This application consumes a lot of memory to run
# 		A more powerful machine (4GB RAM+) may be more suitable
