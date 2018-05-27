#include "Shape.h"
#ifndef RectangleS_H
#define RectangleS_H

class RectangleS : public Shape
{
	DECLARE_SERIAL(RectangleS)
public : 
	RectangleS (CPoint, CPoint);
	RectangleS (int =0, int =0, int =0, int =0);
	~RectangleS ();
	void draw (CDC *dc);
	bool pointIsIn(CPoint);
};

#endif