#include "stdafx.h"
#include "point.h"

IMPLEMENT_SERIAL(PointS, CObject, 1)

PointS::PointS(CPoint point)
	: Shape(point,point)
{
}

PointS::PointS (int x1,int y1,int x2,int y2)
	: Shape(x1,y1,x2,y2)
{}

PointS::~PointS()
{}

void PointS::draw(CDC *dc)
{
	dc->MoveTo(start);
	dc->LineTo(start);
}
