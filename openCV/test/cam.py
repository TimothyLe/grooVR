import cv2
import numpy as np

cap = cv2.VideoCapture(0)
while True:
	ret,img = cap.read()
	cv2.imshow('Video output', img)
	k = cv2.waitKey(10) & 0xff
	if k == 27:
		break
cap.release()
cv2.destroyAllWindows()
