DECLARE @BranCode nvarchar(11)
SET @BranCode=N'BranCHN.115'

	
	DECLARE @IndexTable TABLE
			(
				IndexID 	INT identity(1,1),
				DatePara	NVARCHAR(64),
				BranCode	NVARCHAR(64),
				BranName	NVARCHAR(64),
				PartCode	NVARCHAR(64),
				PartName	NVARCHAR(64),
				CateCode	NVARCHAR(64),
				ProdName	NVARCHAR(64),
				OutStkQty	INT,
				OutStkAmt DECIMAL(20,6),
				DNNo		NVARCHAR(64),
				ComCode		NVARCHAR(64),
				IssueDate	DATETIME
			)
	INSERT	INTO @IndexTable
		(
			 DatePara
			,BranCode
			,BranName	
			,PartCode
			,PartName
			,CateCode
			,ProdName
			,OutStkQty
			,OutStkAmt
			,DNNo
			,ComCode
			,IssueDate
		)
    SELECT
	     CONVERT(VARCHAR, WOH.IssueDate, 111)		    		AS DatePara				
		 ,Branch.BranCode										AS BranCode				
		 ,Branch.ShortName										AS BranName				
		 ,WOD.PartCode											AS PartCode				
		 ,ISNULL(Part.ShortNameCHN, Part.FullNameCHN)			AS PartName
		 ,PD.CateCode											AS CateCode
		 ,ISNULL(PD.ShortName, PD.FullName)						AS ProdName
		 ,WOD.Qty												AS OutStkQty 
		 ,WOD.Qty
			*dbo.FN_PriceGet(Branch.ComCode
							,Branch.ComCode
							,WOD.PartCode
							,GETDATE())					AS	OutStkAmt--出库金额
		 ,WOH.WORelaNo											AS DNNo
		 ,Branch.ComCode										AS ComCode
		 ,CONVERT(VARCHAR,WOH.IssueDate,111) AS IssueDate
	FROM 	ibg_WOH 						AS WOH
	LEFT JOIN ibg_WOD 						AS WOD		ON WOH.WOGUID = WOD.WOGUID
	LEFT JOIN ibg_Part 						AS Part		ON WOD.PartCode = Part.PartCode
	LEFT JOIN ibg_Product 					AS PD 		ON Part.MainProdCode = PD.ProdCode
	LEFT JOIN ibg_StockAccount 				AS StockAccount ON WOH.StkAccCodeTarget = StockAccount.StkAccCode
	LEFT JOIN ibg_Branch 					AS Branch	ON StockAccount.BranCodeMgt = Branch.BranCode
	WHERE	WOH.StkAccCodeSource 	='WH.BranCHN.SPC.None.BranCHN.SPC.None'
			AND WOH.WOType				= 'WOType.PC2SVC'
			AND WOH.IssueDate IS NOT NULL
			AND WOH.AvailableFlag		= 'AvailableFlag.Enable'
		AND	Branch.BranCode											= @BranCode
		 	
		ORDER BY
			WOH.IssueDate
			,Branch.BranCode
			,WOH.WORelaNo
			,Part.PartCode



		SELECT 
		InStkTemp.PartCode AS '零件代码', --零件代码
		InStkTemp.PartName AS '零件名称', --零件名称
		SUM(InStkTemp.OutStkQty)					AS	'出库数量',--数量
		SUM(InStkTemp.OutStkAmt)					AS	'出库金额',--金额
		InStkTemp.BranCode AS '分店代码',--分店代码
		InStkTemp.BranName AS '分店名称',--分店名称
		InStkTemp.IssueDate AS '出库时间'--出库时间
		FROM 
	 (select * from @IndexTable) AS InStkTemp

	 GROUP BY InStkTemp.PartCode,InStkTemp.PartName,InStkTemp.BranName,InStkTemp.BranCode,InStkTemp.IssueDate
ORDER BY InStkTemp.BranCode,InStkTemp.IssueDate,InStkTemp.PartCode

	
		
			