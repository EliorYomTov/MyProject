#include "stdafx.h"
#include "Shape.h"
#ifndef LineS_H
#define LineS_H

class LineS : public Shape
{
	DECLARE_SERIAL(LineS)
public : 
	LineS (CPoint, CPoint);
	LineS (int =0, int =0, int =0, int =0);
	~LineS ();
	void draw (CDC *dc);
	bool pointIsIn(CPoint);
};
#endif