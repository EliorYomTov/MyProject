
#include "stdafx.h"
#ifndef SHAPE_H
#define SHAPE_H


class Shape : public CObject
{
public :
	Shape (CPoint, CPoint);
	Shape (int =0, int =0, int =0, int =0);
	Shape (const Shape&);
	virtual ~Shape();
	void Serialize (CArchive&);
	const Shape & operator= (const Shape&);
	void setStart (const CPoint);
	void setEnd (const CPoint);
	virtual void draw (CDC *dc) =0;
	virtual bool pointIsIn(CPoint) =0;

	COLORREF borderColor, fillColor;
	int borderSize;
	CPoint start, end;
};
#endif
