#include"stdafx.h"
#include"Triangle.h"

IMPLEMENT_SERIAL(TriangleS, CObject, 1)

TriangleS::TriangleS(CPoint start, CPoint midPoint, CPoint end)
	: Shape(start,end)
{
	this->midPoint = midPoint;
}

TriangleS::TriangleS (int x1,int y1,int x2,int y2, int x3, int y3)
	: Shape(x1,y1,x2,y2)
{
	this->midPoint.x = x2;
	this->midPoint.y = y2;
}

TriangleS::~TriangleS()
{}

void TriangleS::draw(CDC *dc)
{
	midPoint .y = end.y;
	midPoint.x = start.x - (end.x - start.x); 
	CPoint temp[3] = {start, midPoint, end};
	dc->Polygon(temp,3);
}

bool TriangleS::pointIsIn(CPoint point)
{
	int as_x = point.x-start.x;
    int as_y = point.y-start.y;

	bool s_ab = (midPoint.x-start.x)*as_y-(midPoint.y-start.y)*as_x > 0;

    if((end.x-start.x)*as_y-(end.y-start.y)*as_x > 0 == s_ab) return false;

    if((end.x-midPoint.x)*(point.y-midPoint.y)-(end.y-midPoint.y)*(point.x-midPoint.x) > 0 != s_ab) return false;

    return true;
}