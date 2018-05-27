#include "Shape.h"
#ifndef TRIANGLE_H
#define TRIANGLE_H

class TriangleS : public Shape
{
	DECLARE_SERIAL(TriangleS)

public : 
	TriangleS (CPoint, CPoint, CPoint);
	TriangleS (int =0, int =0, int =0, int =0, int =0, int =0);
	~TriangleS ();
	void draw(CDC *dc);
	bool pointIsIn(CPoint) ;
private :
	CPoint midPoint;
};
#endif