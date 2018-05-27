#include "Shape.h"
#ifndef POINT_H
#define POINT_H

class PointS : public Shape
{
	DECLARE_SERIAL(PointS)

public : 
	PointS (CPoint);
	PointS (int =0, int =0, int =0, int =0);
	~PointS ();
	void draw(CDC *dc);
};
#endif