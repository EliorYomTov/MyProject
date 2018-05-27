#include "Shape.h"
#ifndef EllipseNew_H
#define EllipseNew_H

class EllipseS : public Shape
{
	DECLARE_SERIAL(EllipseS)
public : 
	EllipseS (CPoint, CPoint);
	EllipseS (int =0, int =0, int =0, int =0);
	~EllipseS ();
	void draw(CDC *dc);
	bool pointIsIn(CPoint);
};
#endif